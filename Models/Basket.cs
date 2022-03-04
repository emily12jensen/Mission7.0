using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Mission7._0.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();
        public void AddItem( Books bo, int qty)
        {
            BasketLineItem line = Items.Where(p => p.Books.Title == bo.Title).FirstOrDefault();

            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Books = bo,
                    Quantity = qty,
                    Price = bo.Price
                    
                    
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }
        public double CalculateTotal()
        {
// change this to the price of the books. 
            double sum = Items.Sum(x => x.Quantity * x.Price);
            return sum;
        }

    }
    
    public class BasketLineItem
    {
        public int LineID { get; set;  }
        //check that it is Books and not Book
        public Books Books { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
