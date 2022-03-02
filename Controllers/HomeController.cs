using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission7._0.Models;
using Mission7._0.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7._0.Controllers
{
    public class HomeController : Controller
    {
        private IBookStoreRepository repo;
     
        public HomeController(IBookStoreRepository temp)
        {
            repo = temp;
        }
        
        public IActionResult Index(string Category, int pageNum = 1)
        {
            int pageSize = 5;


            var x = new BooksViewModel
            {
                Books = repo.Books
                .Where(b => b.Category == Category || Category == null)
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumProjects =
                        (Category == null
                            ? repo.Books.Count()
                            : repo.Books.Where(x => x.Category == Category).Count()),
                    ProjectsPerPage = pageSize,
                    CurrentPage = pageNum

                }

            };

            return View(x);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
