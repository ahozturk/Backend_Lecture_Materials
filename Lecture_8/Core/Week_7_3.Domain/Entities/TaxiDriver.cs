using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_7_3.Domain.Common;

namespace Week_7_3.Domain.Entities
{
    public class TaxiDriver : Person
    {
        public string LicencePlate { get; set; }
    }
}
