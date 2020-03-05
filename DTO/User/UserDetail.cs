using System;
using API.Domain;

namespace API.DTO
{
    public class UserDetailDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}