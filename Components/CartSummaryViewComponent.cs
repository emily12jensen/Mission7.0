using Microsoft.AspNetCore.Mvc;
using Mission7._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7._0.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket purchase;
        public CartSummaryViewComponent(Basket cartService)
        {
            purchase = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(purchase);
        }
    }
}
