using Domain.Entities;
using Domain.Repositories;

namespace Data
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(MyContext context) : base(context)
        {
        }
    }
}