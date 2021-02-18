using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestWithASP_NET5Udemy.Model;
using RestWithASP_NET5Udemy.Model.Base;

namespace RestWithASP_NET5Udemy.Business
{
    public interface IPersonBusiness 
    {
        Person Create(Person person);
        Person FindById(long id);
        Person Update(Person person);
        List<Person> FindAll();
        void Delete(long id);
    }
}
