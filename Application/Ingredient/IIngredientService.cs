using API.Domain;
using API.DTO;
using System;
using System.Collections.Generic;

namespace API.Application
{
    public interface IIngredientService
    {
        ICollection<IngredientDetailDTO> FindAll();
        Ingredient FindById(Guid id);
    }
}