using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture_3.Common;

namespace Lecture_3.Entities
{
    internal class Customer : EntityBase<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetStringCSV()
        {
            return $"{Id},{CreatedDate},{FirstName},{LastName}";
        }

        public void SetValuesCSV(string line) //a191e5b2-de84-4ef9-8e04-039c56111632,9/25/2023 1:33:48 PM +03:00,Name 2,Lastname 2
        {
            string[] values = line.Split(',');
            Id = Guid.Parse(values[0]);
            CreatedDate = DateTimeOffset.Parse(values[1]);
            FirstName = values[2];
            LastName = values[3];
        }
    }
}
