using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vadharuiskafferiet.Application.DTOs;
using Vadharuiskafferiet.Application.Extensions;
using Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities;
using Vadharuiskafferiet.Persistence;

namespace Vadharuiskafferiet.Application.Recepies.Query
{
    public class GetRecepiesHandler : IRequestHandler<GetRecepiesQuery, List<RecepieDTO>>
    {
        private readonly RecepieDbContext _context;

        public GetRecepiesHandler(RecepieDbContext context)
        {
            _context = context;
        }

        public async Task<List<RecepieDTO>> Handle(GetRecepiesQuery request, CancellationToken cancellationToken)
        {
            var recepies = await _context.Recepies
                //.Where(r => r.ContainsIngredients(request.Ingredients))
                .Include(r => r.Ingredients)
                .Select(rec => rec.ToRecepieDTO())
                .ToListAsync();

            return recepies;
        }
    }
}
