using Microsoft.AspNetCore.Mvc;
using Productify.Domain.Entities;
using Productify.Persistence.Contexts;

namespace Productify.MVC.Controllers
{
    public class ProductController : Controller
    {
        //List<Product> _products = new()
        //{
        //    new Product("Laptop Computer"),
        //    new Product("Smartphone"),
        //    new Product("Wireless Headphones"),
        //    new Product("Digital Camera"),
        //    new Product("Tablet")
        //};

        ProductifyDbContext _context;

        public ProductController()
        {
            _context = new();
        }

        public IActionResult GetAll()
        {
            return View(_context.Products.ToList());
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(string productName)
        {
            _context.Products.Add(new(productName));

            _context.SaveChanges();

            return View();
        }
    }
}
