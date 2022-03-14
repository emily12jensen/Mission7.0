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
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }




        //this is add on from josh
        protected override void OnModelCreating(ModelBuilder book)
        {
            //book.Entity<Book>(entity =>
            //{
            //    entity.HasKey(e => e.BookId);
            //    entity.Property(e => e.BookId);
            //    entity.Property(e => e.Title).IsRequired();
            //});
            //OnModelCreatingPartial(book);

            book.Entity<Book>().HasData(
                new Book
                {
                    BookID = 1,
                    Title = "Les Miserables",
                    Author = "Victor Hugo",
                    Publisher = "Signet",
                    ISBN = "978-0451419439",
                    Classification = "Fiction",
                    Category = "Classic",
                    PageCount = 1488,
                    Price = 9.95,
                },
                new Book
                {
                    BookID = 2,
                    Title = "Team of Rivals",
                    Author = "Doris Kearns Goodwin",
                    Publisher = "Simon & Schuster",
                    ISBN = "978-0743270755",
                    Classification = "Non-Fiction",
                    Category = "Biography",
                    PageCount = 944,
                    Price = 14.58,
                },
                new Book
                {
                    BookID = 3,
                    Title = "The Snowball",
                    Author = "Alice Schroeder",
                    Publisher = "Bantam",
                    ISBN = "978-0553384611",
                    Classification = "Non-Fiction",
                    Category = "Biography",
                    PageCount = 832,
                    Price = 21.54,
                },
                new Book
                {
                    BookID = 4,
                    Title = "American Ulysses",
                    Author = "Ronald C. White",
                    Publisher = "Random House",
                    ISBN = "978-0812981254",
                    Classification = "Non-Fiction",
                    Category = "Biography",
                    PageCount = 864,
                    Price = 11.61,
                },
                new Book
                {
                    BookID = 5,
                    Title = "Unbroken",
                    Author = "Laura Hillenbrand",
                    Publisher = "Random House",
                    ISBN = "978-0812974492",
                    Classification = "Non-Fiction",
                    Category = "Historical",
                    PageCount = 528,
                    Price = 13.33,
                },
                new Book
                {
                    BookID = 6,
                    Title = "The Great Train Robbery",
                    Author = "Michael Crichton",
                    Publisher = "Random House",
                    ISBN = "978-0804171281",
                    Classification = "Fiction",
                    Category = "Historical",
                    PageCount = 288,
                    Price = 13.33,
                },
                new Book
                {
                    BookID = 7,
                    Title = "Deep Work",
                    Author = "Cal Newport",
                    Publisher = "Vintage",
                    ISBN = "978-1455586691",
                    Classification = "Non-Fiction",
                    Category = "Self-Help",
                    PageCount = 304,
                    Price = 14.99,
                },
                new Book
                {
                    BookID = 8,
                    Title = "It's Your Ship",
                    Author = "Michael Abrashoff",
                    Publisher = "Grand Central Publishing",
                    ISBN = "978-1455523023",
                    Classification = "Non-Fiction",
                    Category = "Self-Help",
                    PageCount = 240,
                    Price = 21.66,
                },
                new Book
                {
                    BookID = 9,
                    Title = "The Virgin Way",
                    Author = "Richard Branson",
                    Publisher = "Grand Central Publishing",
                    ISBN = "978-1591847984",
                    Classification = "Non-Fiction",
                    Category = "Business",
                    PageCount = 400,
                    Price = 29.16,
                },
                new Book
                {
                    BookID = 10,
                    Title = "Sycamore Row",
                    Author = "John Grisham",
                    Publisher = "Batnam",
                    ISBN = "978-0553393613",
                    Classification = "Fiction",
                    Category = "Thriller",
                    PageCount = 642,
                    Price = 15.03,
                },
                new Book
                {
                    BookID = 11,
                    Title = "The Way I Heard It",
                    Author = "Mike Rowe",
                    Publisher = "Gallery Books",
                    ISBN = "978-1982131470",
                    Classification = "Fiction",
                    Category = "Historical",
                    PageCount = 272,
                    Price = 12.30,
                },
                new Book
                {
                    BookID = 12,
                    Title = "The Complete Personal Memoirs of Ulysses S. Grant",
                    Author = "Unisses S. Grant",
                    Publisher = "CreateSpace Independent Publishing Platform",
                    ISBN = "978-1481216043",
                    Classification = "Non-Fiction",
                    Category = "Biography",
                    PageCount = 552,
                    Price = 19.99,
                },
                new Book
                {
                    BookID = 13,
                    Title = "The Screwtape Letters",
                    Author = "C.S. Lewis",
                    Publisher = "HarperOne",
                    ISBN = "978-0060652937",
                    Classification = "Fiction",
                    Category = "Christian",
                    PageCount = 209,
                    Price = 10.27,
                },
                new Book
                {
                    BookID = 14,
                    Title = "Sleep Smarter",
                    Author = "Shawn Stevenson",
                    Publisher = "Rodale Books",
                    ISBN = "978-1623367398",
                    Classification = "Non-Fiction",
                    Category = "Health",
                    PageCount = 288,
                    Price = 17.59,
                },
                new Book
                {
                    BookID = 15,
                    Title = "Titan",
                    Author = "Ron Chernow",
                    Publisher = "Vintage",
                    ISBN = "978-1400077304",
                    Classification = "Non-Fiction",
                    Category = "Biography",
                    PageCount = 832,
                    Price = 16.59,
                },
                new Book
                {
                    BookID = 16,
                    Title = "The Hunt for Red October",
                    Author = "Tom Clancy",
                    Publisher = "Berkley",
                    ISBN = "978-0440001027",
                    Classification = "Fiction",
                    Category = "Action",
                    PageCount = 656,
                    Price = 9.99,
                }
                );
        }
        private void OnModelCreatingPartial(object modelBuilder)
        {
            throw new NotImplementedException();
        }
    }

}
