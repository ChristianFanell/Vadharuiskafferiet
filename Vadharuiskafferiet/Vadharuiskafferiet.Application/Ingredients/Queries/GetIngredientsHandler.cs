using MediatR;
using Microsoft.EntityFrameworkCore;
using Vadharuiskafferiet.Application.DTOs;
using Vadharuiskafferiet.Application.Extensions;
using Vadharuiskafferiet.Persistence;

namespace Vadharuiskafferiet.Application.Ingredients.Queries
{
    public class GetIngredientsHandler : IRequestHandler<GetIngredientsQuery, List<IngredientDTO>>
    {
        private readonly RecepieDbContext _context;
        public GetIngredientsHandler(RecepieDbContext context)
        {
            _context = context;
        }

        public async Task<List<IngredientDTO>> Handle(GetIngredientsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Ingredients.Select(ingredient => ingredient.ToIngredientDTO()).ToListAsync();
        }
    }
}
