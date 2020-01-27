using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public class Collection<T>
    {
        public List<T> Data { get; set; }
    }
}
