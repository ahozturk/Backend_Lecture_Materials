using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_7_3.Domain.Entities;

namespace Week_7_3.Domain.Common
{
    public class Person : EntityBase<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public BankAccount? Account { get; set; }
    }
}
