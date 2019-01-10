using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }
        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Claudiney",
                LastName = "Nascimento",
                Address = "Longe do Brasil",
                Gender = "Male"
            };
        }

        public void Delete(Person person)
        {
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPersons(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPersons(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person " + i,
                LastName = "LastNamet",
                Address = "Some Address",
                Gender = "Not say"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
