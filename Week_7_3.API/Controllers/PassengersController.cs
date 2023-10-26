using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week_7_3.API.Models;
using Week_7_3.Domain.Entities;
using Week_7_3.Persistence.Contexts;

namespace Week_7_3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        readonly Week_7_3DbContext _context;

        public PassengersController(Week_7_3DbContext context)
        {
            _context = context;
        }


        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            return Ok(_context.Passengers.ToList());
        }

        [HttpPost("[action]")]

        public IActionResult CreatePassenger([FromBody] CreatePassengerRequest createPassengerRequest)
        {
            Passenger passenger = new()
            {
                Name = createPassengerRequest.Name,
                Surname = createPassengerRequest.Surname,
                PhoneNumber = createPassengerRequest.PhoneNumber,
                City = createPassengerRequest.City,
                Account = createPassengerRequest.Account,
    };

            _context.Passengers.Add(passenger);

            _context.SaveChanges();

            return Ok();
        }


    }
}
