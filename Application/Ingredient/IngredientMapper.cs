using API.DTO;
using API.Domain;

namespace API.Application
{
    public class IngredientMapper : IIngredientMapper
    {
        public IngredientDetailDTO ToIngredientDetail(Ingredient ingredient)
        {
            return new IngredientDetailDTO()
            {
                Id = ingredient.Id,
                Name = ingredient.Name
            };
        }
    }
}