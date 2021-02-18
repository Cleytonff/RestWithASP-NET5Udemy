using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestWithASP_NET5Udemy.Model;

namespace RestWithASP_NET5Udemy.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long id);
        Person Update(Person person);
        List<Person> FindAll();
        void Delete(long id);

        bool Exists(long id);
    }
}
