using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;

namespace WebApp.Services
{
    public class MainService : IMainService
    {
        private readonly IPersonRepository _personRepository;

        public MainService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<IEnumerable<Person>> RetrieveAllPersons()
        {
            return await _personRepository.All();
        }
    }
}