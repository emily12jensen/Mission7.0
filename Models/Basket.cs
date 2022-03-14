using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7._0.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();
        public virtual void AddItem( Book bo, int qty)
        {
            BasketLineItem line = Items.Where(p => p.Books.BookID == bo.BookID).FirstOrDefault();

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
        //added for cart totals on top of page
        public decimal ComputeTotalValue() =>
            Items.Sum(e => e.Books.Price * e.Quantity);

        public virtual void RemoveItem(Book bo)
        {
            Items.RemoveAll(x => x.Books.BookID == bo.BookID);
    }
        public virtual void ClearBasket()
        {
            Items.Clear();
        }
        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Books.Price);
            return sum;
        }

    }


    
    public class BasketLineItem
    {
        [Key]
        public int LineID { get; set;  }
        //check that it is Books and not Book
        public Book Books { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
