using Freelancer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Entities
{
    internal class Customer : Person<Guid>
    {
        public string PhoneNumber { get; set; }
        //Balance
        public string GetValuesCSV()
        {
            return $"{Id},{CreatedOn},{FirstName},{LastName},{PhoneNumber}";
        }
    }


}
