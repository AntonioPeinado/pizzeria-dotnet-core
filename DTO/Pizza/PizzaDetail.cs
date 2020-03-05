using System;
using System.Collections.Generic;

namespace API.DTO
{
    public class PizzaDetailDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        // TODO: imagen
        public ICollection<CommentDetailDTO> Comments { get; set; }
        public ICollection<IngredientDetailDTO> Ingredients { get; set; }


    }
}