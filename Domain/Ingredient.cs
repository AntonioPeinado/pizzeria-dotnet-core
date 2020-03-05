using System;

namespace API.Domain
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}