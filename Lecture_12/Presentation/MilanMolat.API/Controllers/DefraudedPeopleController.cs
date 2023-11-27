using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        }

        public string GetDefraudedPersonName(Guid defraudedPersonId)
        {
            var person = _context.DefraudedPeople.FirstOrDefault(x => x.Id == defraudedPersonId);

            return person.FirstName;
        }
    }
}
