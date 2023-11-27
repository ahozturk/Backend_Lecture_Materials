using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilanMolat.Domain.Entities;
using MilanMolat.Infrastructure.Contexts;

namespace MilanMolat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefraudedPeopleController : ControllerBase
    {
        private readonly MilanMolatDbContext _context;

        public DefraudedPeopleController(MilanMolatDbContext context)
        {
            _context = context;
            List<DefraudedPerson> defraudedPeople = new List<DefraudedPerson>
            {
                new DefraudedPerson { Id = Guid.NewGuid(), FirstName = "John", LastName = "Doe" },
                new DefraudedPerson { Id = Guid.NewGuid(), FirstName = "Jane", LastName = "Smith" },
                new DefraudedPerson { Id = Guid.NewGuid(), FirstName = "Alice", LastName = "Johnson" },
                new DefraudedPerson { Id = Guid.NewGuid(), FirstName = "Bob", LastName = "Brown" },
                new DefraudedPerson { Id = Guid.NewGuid(), FirstName = "Charlie", LastName = "Davis" }
            };
            _context.DefraudedPeople.AddRange(defraudedPeople);
            _context.SaveChanges();
            Console.WriteLine(string.Join("\n", defraudedPeople.Select(x => x.Id).ToList()));

        }

        [HttpGet]
        public string GetDefraudedPersonName(Guid defraudedPersonId)
        {

            var person = _context.DefraudedPeople.FirstOrDefault(x => x.Id == defraudedPersonId);



            return person is null ? "Coulnd't Find!" : person.FirstName ;
        }
    }
}
