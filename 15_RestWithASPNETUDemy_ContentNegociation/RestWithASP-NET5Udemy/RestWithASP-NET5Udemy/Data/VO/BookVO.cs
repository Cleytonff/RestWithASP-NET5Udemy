using RestWithASP_NET5Udemy.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASP_NET5Udemy.Model
{
    public class BookVO
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }
        public DateTime LaunchDate { get; set; }

    }
}
