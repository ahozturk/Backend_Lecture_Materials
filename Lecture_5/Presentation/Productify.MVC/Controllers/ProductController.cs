using Microsoft.AspNetCore.Mvc;
using Productify.Domain.Entities;

namespace Productify.MVC.Controllers
{
    public class ProductController : Controller
    {
        List<Product> _products = new()
        {
            new Product("Laptop Computer"),
            new Product("Smartphone"),
            new Product("Wireless Headphones"),
            new Product("Digital Camera"),
            new Product("Tablet")
        };

        public IActionResult GetAll()
        {
            return View(_products);
        }

        public IActionResult AddProduct()
        {
            return View();
        }
    }
}
