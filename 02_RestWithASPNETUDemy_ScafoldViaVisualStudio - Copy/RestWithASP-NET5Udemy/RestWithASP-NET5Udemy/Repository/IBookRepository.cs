using RestWithASP_NET5Udemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NET5Udemy.Repository
{
    public interface IBookRepository
    {

        Book Create(Book person);
        Book FindById(long id);
        Book Update(Book person);
        List<Book> FindAll();
        void Delete(long id);

        bool Exists(long id);


    }
}
