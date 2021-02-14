using System;
using System.Dynamic;
using System.Threading.Tasks;

namespace GenericRepository
{
    public interface IUnitOfWork<T>: IDisposable where T: class, IEntity
    {
        IRepository<T> Repository { get; }

        Task Commit();
    }
}  