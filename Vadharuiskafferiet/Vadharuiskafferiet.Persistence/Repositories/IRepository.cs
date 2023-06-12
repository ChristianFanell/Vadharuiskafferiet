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
        Task<List<T>> FindAsync(List<string> list);
        Task<T> FindByIdAsync(Guid id);
        //Task<T> AddAsync(T entity);
        //Task<T> UpdateAsync(T entity);
        //Task<T> DeleteAsync(Guid id);
    }
}
