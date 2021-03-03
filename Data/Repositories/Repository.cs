using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class Repository<T> : IRepository<T> where T: class, IEntity
    {
        private DbSet<T> Table { get; set; }

        public Repository(MyContext context)
        {
            Table = context.Set<T>();
        }

        public async Task Add(T entity) => await Table.AddAsync(entity);

        public async Task Add(IEnumerable<T> entities) => await Table.AddRangeAsync(entities);
        
        public async Task<IList<T>> All() => await Table.AsNoTracking().ToListAsync();

        public void Update(T entity) => Table.Update(entity);

        public void Update(IEnumerable<T> entities) => Table.UpdateRange(entities);

        public void Delete(T entity) => Table.Remove(entity);

        public void Delete(IEnumerable<T> entities) => Table.RemoveRange(entities);

        public async Task<T> GetById(Guid id) => await Table.SingleAsync(x => x.Id == id);

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return Table.Where<T>(expression);
        }
    }
}