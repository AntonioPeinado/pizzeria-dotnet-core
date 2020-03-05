using API.DTO;
using API.Domain;

namespace API.Application
{
    public interface IIngredientMapper
    {
        IngredientDetailDTO ToIngredientDetail(Ingredient ingredient);
    }
}