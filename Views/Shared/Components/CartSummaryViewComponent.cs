using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Views.Shared.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public CartSummaryViewComponent(Basket basketservice)
        {
            basket = basketservice;
        }
      public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
