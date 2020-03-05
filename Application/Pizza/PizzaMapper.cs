using API.DTO;
using API.Domain;
using System;
using System.Linq;
using System.Collections.Generic;

namespace API.Application
{
    public class PizzaMapper : IPizzaMapper
    {
        private readonly ICommentMapper _commentMapper;
        private readonly IIngredientMapper _ingredientMapper;

        public PizzaMapper(ICommentMapper commentMapper, IIngredientMapper ingredientMapper)
        {
            _commentMapper = commentMapper;
            _ingredientMapper = ingredientMapper;
        }
        public Pizza ToPizza(CreatePizzaDTO dto)
        {
            return new Pizza
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                PizzaIngredients = new List<PizzaIngredient>(),
                Comments = new List<Comment>()
                //TODO: imagen
            };
        }
        public PizzaDetailDTO ToPizzaDetail(Pizza pizza)
        {
            return new PizzaDetailDTO()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                Comments = pizza.Comments.Select(_commentMapper.ToCommentDetail).ToList(),
                Ingredients = pizza.PizzaIngredients.Select(pi => _ingredientMapper.ToIngredientDetail(pi.Ingredient)).ToList()
                // TODO: imagen
            };
        }
        public PizzaSummaryDTO ToPizzaSummary(Pizza pizza)
        {
            return new PizzaSummaryDTO()
            {
                Id = pizza.Id,
                Name = pizza.Name
                // TODO: imagen
            };
        }
    }
}