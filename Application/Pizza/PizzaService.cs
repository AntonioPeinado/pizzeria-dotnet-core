using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using API.Domain;
using API.DTO;
using API.Infraestructure;

namespace API.Application
{
    public class PizzaService : BaseService, IPizzaService
    {
        private readonly PizzeriaContext _context;

        private IPizzaIngredientService _pizzaIngredientsService;
        private readonly IPizzaMapper _pizzaMapper;

        public PizzaService(PizzeriaContext context, IPizzaMapper pizzaMapper, IPizzaIngredientService pizzaIngredientService) : base(context)
        {
            _context = context;
            _pizzaMapper = pizzaMapper;
            _pizzaIngredientsService = pizzaIngredientService;
        }

        public void AddComment(Guid id, Comment comment)
        {
            var pizza = _context.Pizza.Find(id);
            pizza.AddComment(comment);
        }

        public PizzaDetailDTO Create(CreatePizzaDTO dto)
        {
            var pizza = _pizzaMapper.ToPizza(dto);
            _pizzaIngredientsService.AddIngredients(pizza, dto.Ingredients);
            _context.Pizza.Add(pizza);
            _context.SaveChanges();
            return _pizzaMapper.ToPizzaDetail(pizza);
        }

        public ICollection<PizzaSummaryDTO> FindAll()
        {
            return _context.Pizza.Select(_pizzaMapper.ToPizzaSummary).ToList();
        }

        public PizzaDetailDTO FindById(Guid id)
        {
            var pizza = _context.Pizza
                .AsNoTracking()
                .Include(p => p.Comments)
                .ThenInclude(c => c.User)
                .Include(p => p.PizzaIngredients)
                .ThenInclude(pi => pi.Ingredient)
                .SingleOrDefault(p => p.Id == id);
            return _pizzaMapper.ToPizzaDetail(pizza);
        }
    }
}