using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace WebApp.Services
{
    public interface IMainService
    {
        public Task<IEnumerable<Person>> RetrieveAllPersons();
    }
}