using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities;
using Vadharuiskafferiet.Persistence;

namespace Vadharuiskafferiet.Persistence.Repositories
{
    public class RecepieRepository : IRepository<Recepie>
    {
        private readonly RecepieDbContext _context;

        public RecepieRepository(RecepieDbContext context)
        {
            _context = context;
        }


        public async Task<List<Recepie>> FindAsync(List<string> list)
        {
            return await _context.Recepies
                .Where(r => r.ContainsIngredients(list))
                .Include(e => e.Ingredients)
                .ToListAsync();
        }


        public async Task<Recepie> FindByIdAsync(Guid id)
        {
            var result = await _context.Recepies
                .Where(r => r.Id == id)
                .Include(e => e.Ingredients)
                .FirstOrDefaultAsync();

            return result;
        }

        public async Task<List<Ingredient>> GetAllIngredientsAsync()
        {
            return await _context.Ingredients.ToListAsync();
        }

        public async Task<List<Ingredient>> FindIngredientsByNameAsync(string name)
        {
            return await _context.Ingredients.Where(ingr => ingr.Name.Value.Contains(name)).ToListAsync();
        }

        //public Task<Recepie> UpdateAsync(Recepie entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
