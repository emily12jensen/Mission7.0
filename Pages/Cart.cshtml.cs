using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission7._0.Infrastructure;
using Mission7._0.Models;

namespace Mission7._0.Pages
{
    public class CartModel : PageModel
    {
        private IBookStoreRepository repo { get; set; }
        public CartModel (IBookStoreRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }
        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            //basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
        }
        public IActionResult OnPost( string title, string returnUrl)
        {
            //basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
            Book b = repo.Books.FirstOrDefault(x => x.Title == title);
            basket.AddItem(b, 1);

           // HttpContext.Session.SetJson("basket", basket);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(int bookId, string returnUrl)
        {
            basket.RemoveItem(repo.Books.FirstOrDefault(x => x.BookID == bookId));
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
