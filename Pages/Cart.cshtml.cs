using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission7._0.Models;

namespace Mission7._0.Pages
{
    public class CartModel : PageModel
    {
        private IBookStoreRepository repo { get; set; }
        public CartModel (IBookStoreRepository temp)
        {
            repo = temp;
        }
        public Basket basket { get; set; }
        public void OnGet(Basket b)
        {
            basket = b;
        }
        public IActionResult OnPost( string Title)
        {
            basket = new Basket();
            Books b = repo.Books.FirstOrDefault(x => x.Title == Title);
            basket.AddItem(b, 1);
            return RedirectToPage(basket);
        }
    }
}
