using Microsoft.AspNetCore.Mvc;
using Mission7._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7._0.Components
{
    public class TypesViewComponent : ViewComponent
    {
       
            private IBookStoreRepository repo { get; set; }

            public TypesViewComponent(IBookStoreRepository temp)
            {
                repo = temp;
            }

            public IViewComponentResult Invoke()
            {

                ViewBag.SelectedType = RouteData?.Values["Category"];

                var types = repo.Books
                    .Select(x => x.Category)
                    .Distinct()
                    .OrderBy(x => x);

                return View(types);
            }
        
    }
}
