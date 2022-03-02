using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                    Quantity = qty
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
            double sum = Items.Sum(x => x.Quantity * 10);
            return sum;
        }

    }

    
    public class BasketLineItem
    {
        public int LineID { get; set;  }
        //check that it is Books and not Book
        public Books Books { get; set; }
        public int Quantity { get; set; }
    }
}
