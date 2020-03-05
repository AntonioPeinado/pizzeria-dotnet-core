using Microsoft.AspNetCore.Mvc;
using API.Application;
using API.DTO;
using System;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzasController : ControllerBase
    {
        private readonly IPizzaService _pizzaService;
        public PizzasController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pizzaService.FindAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_pizzaService.FindById(id));
        }
        [HttpPost]
        public IActionResult Post([FromBody] CreatePizzaDTO createPizzaDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var pizzaDetail = _pizzaService.Create(createPizzaDTO);
            return StatusCode(201, pizzaDetail);
        }
    }
}
