using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture_3.Common;

namespace Lecture_3.Entities
{
    internal class Job : EntityBase<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Customer JobPoster { get; set; }
        public bool IsActive { get; set; }

        public Job(string title, string description, Customer jobPoster)
        {
            Title = title;
            Description = description;
            JobPoster = jobPoster;
            IsActive = true;
        }

    }
}
