using RestWithASP_NET5Udemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASP_NET5Udemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService

    {
        private volatile int count = 0;
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            Console.WriteLine("Registro excluído!");
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }


        public Person FindById(long id)
        {
            return new Person {
                Id = 1,
                FirstName = "Luciana",
                LastName = "Franco",
                Address = "Vila Matilde - São Paulo - Brasil",
                Gender = "Female"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }


        private Person MockPerson(int i)
        {

            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person name"+i,
                LastName = "Person Last Name" + i,
                Address = "Some Address" + i,
                Gender = "Female"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
