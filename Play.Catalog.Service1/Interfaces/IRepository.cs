using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Play.Catalog.Service1.Entities;

namespace Play.Catalog.Service1.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        Task CreateAsync(T entity);
        Task<IReadOnlyCollection<T>> GetAllAsync();
        Task<T> GetAsync(Guid id);
        Task RemoveAsync(Guid id);
        Task UpdateAsync(T entity);
    }
}