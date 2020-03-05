using API.DTO;
using API.Domain;

namespace API.Application
{
    public interface IPizzaMapper
    {
        Pizza ToPizza(CreatePizzaDTO dto);
        PizzaDetailDTO ToPizzaDetail(Pizza pizza);
        PizzaSummaryDTO ToPizzaSummary(Pizza pizza);
    }
}