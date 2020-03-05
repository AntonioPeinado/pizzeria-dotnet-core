using System.Linq;
using System.Collections.Generic;
using API.DTO;
using API.Infraestructure;
using API.Domain;
using System;

namespace API.Application
{
    public class IngredientService : BaseService, IIngredientService
    {
        private readonly PizzeriaContext _context;
        private readonly IIngredientMapper _ingredientMapper;

        public IngredientService(PizzeriaContext context, IIngredientMapper ingredientMapper) : base(context)
        {
            _context = context;
            _ingredientMapper = ingredientMapper;
        }
        public ICollection<IngredientDetailDTO> FindAll()
        {
            return _context.Ingredient.Select(_ingredientMapper.ToIngredientDetail).ToList();
        }
        public Ingredient FindById(Guid id)
        {
            var ingredient = _context.Ingredient.Find(id);
            return ingredient;
        }
    }
}