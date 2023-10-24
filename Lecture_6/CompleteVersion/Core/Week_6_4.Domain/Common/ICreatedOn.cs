using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6_4.Domain.Common
{
    public interface ICreatedOn
    {
        public string? CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
