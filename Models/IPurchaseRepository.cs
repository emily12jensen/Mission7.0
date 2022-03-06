using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7._0.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Purchases { get; }
        void SavePurchase(Purchase purchase);
    }
}
