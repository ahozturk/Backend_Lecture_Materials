using Microsoft.AspNetCore.Mvc;
using Week_6_4.Domain.Entities;
using Week_6_4.Persistence.Contexts;

namespace Week_6_4.MVC.Controllers
{
    public class BrandController : Controller
    {
        private readonly ReDoMusicDbContext _dbContext;

        public BrandController()
        {
            _dbContext = new();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var brands = _dbContext.Brands.ToList();

            return View(brands);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string brandName, string brandDisplayingText, string brandAddress)
        {
            var brand = new Brand()
            {
                Name = brandName,
                DisplayingText = brandDisplayingText,
                Address = brandAddress,
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.UtcNow,
            };

            _dbContext.Brands.Add(brand);

            _dbContext.SaveChanges();

            return View();
        }

        [Route("[controller]/[action]/{id}")]
        public IActionResult Delete(string id)
        {
            var brand = _dbContext.Brands.Where(x => x.Id == Guid.Parse(id)).FirstOrDefault();

            _dbContext.Brands.Remove(brand);

            _dbContext.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
