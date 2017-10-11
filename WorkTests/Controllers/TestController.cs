using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WorkTests.Models;

namespace WorkTests.Controllers
{
    public class TestController : ApiController
    {
        private IValueCalculator calc;
        private Product[] products = {
new Product {Name = "Kajak", Category="Sporty wodne", Price = 275M},
new Product {Name = "Kamizelka ratunkowa", Category="Sporty wodne", Price = 48.95M},
new Product {Name = "Piłka nożna", Category="Piłka nożna", Price = 19.50M},
new Product {Name = "Flaga narożna", Category="Piłka nożna", Price = 34.95M}
};
        public TestController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalValue = cart.CalculateProductTotal();
            return totalValue.ToString();
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}