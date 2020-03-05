using System.ComponentModel.DataAnnotations;
using System;

namespace API.DTO
{
    public class CreateCommentDTO
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]

        public Guid PizzaId { get; set; }
        [Required]

        public string Text { get; set; }
        [Required]

        public int Score { get; set; }
    }
}