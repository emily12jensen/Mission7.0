using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7._0.Models
{
    public interface IBookStoreRepository 
    {
        IQueryable<Books>Books { get; }
    }
}
