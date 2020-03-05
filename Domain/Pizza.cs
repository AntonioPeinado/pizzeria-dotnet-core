using System;
using System.Linq;
using System.Collections.Generic;

namespace API.Domain
{
    public class Pizza
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public double Price
        {
            get
            {
                return _calculatePrice();
            }
        }

        // TODO: imagen
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<PizzaIngredient> PizzaIngredients { get; set; } = new List<PizzaIngredient>();

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        private double _calculatePrice()
        {
            return PizzaIngredients
                .Select(pi => pi.Ingredient.Price)
                .Sum();
        }
    }
}