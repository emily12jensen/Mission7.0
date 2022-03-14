using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7._0.Models
{
    public class EFPurchaseRepository : IPurchaseRepository
    {
        private BookStoreContext context;
        public EFPurchaseRepository(BookStoreContext temp)
        {
            context = temp;
        }
        //check the books on the end of this line
        public IQueryable<Purchase> Purchases => context.Purchases.Include(x => x.Lines).ThenInclude(x => x.Books);

        public void SavePurchase(Purchase purchase)
        {
            context.AttachRange(purchase.Lines.Select(x => x.Books));
            if (purchase.PurchaseId == 0)
            {
                context.Purchases.Add(purchase);
            }
            context.SaveChanges();
        }
    }
}
