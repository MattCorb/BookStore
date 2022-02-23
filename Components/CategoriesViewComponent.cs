using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Components
{
    public class CategoriesViewComponent : ViewComponent
    {
        private IBookstoreRepository repo { get; set; }
        public CategoriesViewComponent (IBookstoreRepository temp)
        {
            repo = temp;
        }
        
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCat = RouteData?.Values["category"];
            var Categories = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);
            return View(Categories);
        }
    }
}
