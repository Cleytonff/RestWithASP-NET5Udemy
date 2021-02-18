using RestWithASP_NET5Udemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NET5Udemy.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book FindById(long id);
        Book Update(Book book);
        List<Book> FindAll();
        void Delete(long id);
    }
}
