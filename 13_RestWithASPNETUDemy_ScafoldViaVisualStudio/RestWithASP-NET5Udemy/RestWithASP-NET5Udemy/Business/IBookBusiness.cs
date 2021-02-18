using RestWithASP_NET5Udemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NET5Udemy.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        BookVO Update(BookVO book);
        List<BookVO> FindAll();
        void Delete(long id);
    }
}
