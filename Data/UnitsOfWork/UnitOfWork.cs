using System;
using System.Threading.Tasks;
using GenericRepository;

namespace Data.UnitsOfWork
{
    [Obsolete("No used anymore", true)]
    public class UnitOfWork<T> : IUnitOfWork<T> where T: class, IEntity
    {
        private readonly MyContext _context;
        public IRepository<T> Repository { get; }
        
        public UnitOfWork(MyContext context)
        {
            this._context = context;
            Repository = new Repository<T>(context);
        }
        
        public async Task Commit() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}