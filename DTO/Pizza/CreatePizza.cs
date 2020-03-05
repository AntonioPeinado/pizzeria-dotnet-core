using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class CreatePizzaDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public ICollection<Guid> Ingredients { get; set; }

        // TODO: imagen
    }
}