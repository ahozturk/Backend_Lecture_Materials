using Freelancer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Entities
{
    internal class Freelancer : Person<Guid>
    {
        public string WorkExperience { get; set; }
        public List<Review> Reviews { get; set; }

        //todo: Preferred Price
        //todo: Skills
    }
}
