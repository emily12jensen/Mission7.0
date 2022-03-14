using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7._0.Models
{
    public class EFBookStoreRepository : IBookStoreRepository
    {
        private BookStoreContext context { get; set; }
        public EFBookStoreRepository (BookStoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;

        public void SaveBook(Book b)
        {
            context.SaveChanges();
        }

        public void CreateBook(Book b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteProject(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
    }
}
