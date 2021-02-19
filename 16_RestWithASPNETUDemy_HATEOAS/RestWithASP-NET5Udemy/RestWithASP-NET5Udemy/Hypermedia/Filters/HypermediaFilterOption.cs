using RestWithASP_NET5Udemy.Hypermedia.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NET5Udemy.Hypermedia.Filters
{
    public class HypermediaFilterOption
    {
        public List<IResponseEnricher> ContentResponseEnricherList = new List<IResponseEnricher>();
    }
}
