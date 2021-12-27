using System.Collections;
using System.Collections.Generic;

namespace EntityTesting.Models
{
    public interface IRepository<TEntity> where TEntity : class
    {
        AdventureDbContext GetContext();
        IEnumerable<TEntity> All { get; }
        void Add(TEntity e);
        void Update(TEntity e);
        void Delete(TEntity e);
    }
}