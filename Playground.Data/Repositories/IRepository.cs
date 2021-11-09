using System.Collections.Generic;

namespace Playground.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity:class
    {
        IEnumerable<TEntity> All { get; }
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        TEntity FindById(int id);
    }
}