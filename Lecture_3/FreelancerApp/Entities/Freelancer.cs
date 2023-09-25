using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture_3.Common;

namespace Lecture_3.Entities
{
    internal class Freelancer : EntityBase<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Review> Reviews { get; private set; }

        public Freelancer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddReview(Review review)
        {
            if (review != null)
                Reviews.Add(review);
        }
    }
}
