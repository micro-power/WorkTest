using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkTests.Models;

namespace WorkTests.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;
        private Product[] products = {
new Product {Name = "Kajak", Category="Sporty wodne", Price = 275M},
new Product {Name = "Kamizelka ratunkowa", Category="Sporty wodne", Price = 48.95M},
new Product {Name = "Piłka nożna", Category="Piłka nożna", Price = 19.50M},
new Product {Name = "Flaga narożna", Category="Piłka nożna", Price = 34.95M}
};
        public HomeController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalValue = cart.CalculateProductTotal();
            ViewBag.Message = totalValue;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}