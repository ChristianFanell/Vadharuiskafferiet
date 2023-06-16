using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vadharuiskafferiet.Application.DTOs;
using Vadharuiskafferiet.Application.Ingredients.Queries;
using Vadharuiskafferiet.Application.Recepies.Query;

namespace Vadharuiskafferiet.WebbClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecepieController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RecepieController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("recepies")]
        public async Task<IActionResult> GetRecepies([FromBody] IngredientDTO? req)
        {
            var result = await _mediator.Send(new GetRecepiesQuery
            {
                Ingredients = new List<int> { 2, 3, 5},
                IsVegan = true,
                IsVegetarian = true,
            });

            return Ok(result);
        }

    }
}
