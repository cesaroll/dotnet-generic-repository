using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GenericRepository
{
    public interface IRepository<T> where T : class, IEntity
    {
        public Task Add(T entity);
        
        public Task Add(IEnumerable<T> entities);

        public void Update(T entity);

        public void Update(IEnumerable<T> entities);

        public void Delete(T entity);

        public void Delete(IEnumerable<T> entities);

        public Task<T> GetById(Guid id );

        public Task<IList<T>> All();

        public IQueryable<T> Where(Expression<Func<T, bool>> expression);
    }
}