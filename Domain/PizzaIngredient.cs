using System;

namespace API.Domain
{
    public class PizzaIngredient
    {
        public Guid IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public Guid PizzaId { get; set; }

        public Pizza Pizza { get; set; }
    }
}