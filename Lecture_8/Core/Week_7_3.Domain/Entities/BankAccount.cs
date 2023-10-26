using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_7_3.Domain.Common;

namespace Week_7_3.Domain.Entities
{
    public class BankAccount : EntityBase<Guid>
    {
        public Person? Owner { get; set; }
        public decimal Balance { get; set; }
    }
}
