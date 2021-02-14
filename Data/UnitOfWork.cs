using System.ComponentModel.Design.Serialization;
using System.Threading.Tasks;
using GenericRepository;

namespace Data
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T: class, IEntity
    {
        private readonly AppContext context;
        public IRepository<T> Repository { get; }
        
        public UnitOfWork(AppContext context)
        {
            this.context = context;
            Repository = new Repository<T>(context);
        }
        
        public async Task Commit()
        {
            await context.SaveChangesAsync();
        }
        
        public void Dispose()
        {
            context.Dispose();
        }

        
        
    }
}