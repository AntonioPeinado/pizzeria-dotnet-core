using Microsoft.AspNetCore.Mvc;
using API.Application;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;
        public IngredientsController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ingredientService.FindAll());
        }
    }
}
