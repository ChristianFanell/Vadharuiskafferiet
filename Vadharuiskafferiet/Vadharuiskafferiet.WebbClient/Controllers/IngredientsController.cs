using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vadharuiskafferiet.Application.Ingredients.Queries;

namespace Vadharuiskafferiet.WebbClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public IngredientsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("getingredients")]
        public async Task<IActionResult> GetIngredients()
        {
            var result = await _mediator.Send(new GetIngredientsQuery());

            return Ok(result);
        }
    }
}
