using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_6_4.Domain.Common;

namespace Week_6_4.Domain.Entities
{
    public class Brand : EntityBase<Guid>
    {
        public string Name { get; set; }
        public string DisplayingText { get; set; }
        public string Address { get; set; }
    }
}
