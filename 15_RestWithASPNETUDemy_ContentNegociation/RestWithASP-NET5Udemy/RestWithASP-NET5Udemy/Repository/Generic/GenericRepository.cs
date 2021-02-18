using Microsoft.EntityFrameworkCore;
using RestWithASP_NET5Udemy.Model.Base;
using RestWithASP_NET5Udemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASP_NET5Udemy.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private MySQLContext _context;
        private DbSet<T> dataset;
        public GenericRepository(MySQLContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }


        List<T> IRepository<T>.FindAll()
        {
            return dataset.ToList();
        }

        T IRepository<T>.FindById(long id)
        {
            return dataset.SingleOrDefault(p => p.Id.Equals(id));
        }

        T IRepository<T>.Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        T IRepository<T>.Update(T item)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(item.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            } 
            else
            {
                return null;
            }
        }


        void IRepository<T>.Delete(long id)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(id));

            if (result != null)
            {
                try
                {
                    dataset.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        bool IRepository<T>.Exists(long id)
        {
            return dataset.Any(p => p.Id.Equals(id));
        }
    }
}
