using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReDoMusic.Domain.Common;

namespace ReDoMusic.Domain.Entities
{
    public class Brand : EntityBase<Guid>
    {
        public string Name { get; set; }
        public string DisplayText { get; set; }
        public string Address { get; set; }

        //public DateTime EstablishDate { get; set; }
    }
}
