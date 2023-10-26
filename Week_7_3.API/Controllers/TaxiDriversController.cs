using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week_7_3.API.Models;
using Week_7_3.Domain.Entities;
using Week_7_3.Persistence.Contexts;

namespace Week_7_3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxiDriversController : ControllerBase
    {
        readonly Week_7_3DbContext _context;

        public TaxiDriversController()
        {
            _context = new Week_7_3DbContext();
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            return Ok(_context.TaxiDrivers.ToList());
        }
        [HttpPost("[action]")]

        public IActionResult CreateTaxiDriver([FromBody] CreateTaxiDriverRequest taxiDriver)
        {
            TaxiDriver taxiDriver1 = new()
            {
                Name = taxiDriver.Name,
                Surname = taxiDriver.Surname,
                PhoneNumber = taxiDriver.PhoneNumber,
                Account = taxiDriver.Account,
                LicencePlate = taxiDriver.LicencePlate,
            };

            _context.TaxiDrivers.Add(taxiDriver1);

            _context.SaveChanges();

            return Ok();
        }
    }
}