using System;
using System.Collections.Generic;
using API.Domain;

namespace API.Application
{
    public interface IPizzaIngredientService
    {
        void AddIngredients(Pizza pizza, ICollection<Guid> ingredients);
    }
}