﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7._0.Models.ViewModels
{
    public class BooksViewModel
    {
        public IQueryable<Books>Books { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
