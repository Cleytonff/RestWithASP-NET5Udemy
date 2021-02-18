using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestWithASP_NET5Udemy.Data.VO;
using RestWithASP_NET5Udemy.Model;
using RestWithASP_NET5Udemy.Model.Base;

namespace RestWithASP_NET5Udemy.Business
{
    public interface IPersonBusiness 
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        PersonVO Update(PersonVO person);
        List<PersonVO> FindAll();
        void Delete(long id);
    }
}
