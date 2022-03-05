using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7._0.Models
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext()
        {

        }
        public BookStoreContext(DbContextOptions<BookStoreContext> options) 
            : base(options)
        {

        }
        public DbSet<Books> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}
