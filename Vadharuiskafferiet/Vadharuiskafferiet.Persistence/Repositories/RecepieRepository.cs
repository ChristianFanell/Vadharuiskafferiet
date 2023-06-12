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

        public Task<Recepie> AddAsync(Recepie entity)
        {
            throw new NotImplementedException();
        }

        public Task<Recepie> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Recepie> UpdateAsync(Recepie entity)
        {
            throw new NotImplementedException();
        }
    }
}
