using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vadharuiskafferiet.Domain.Aggregates;

namespace Vadharuiskafferiet.Persistence.Repositories
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);
    }
}
