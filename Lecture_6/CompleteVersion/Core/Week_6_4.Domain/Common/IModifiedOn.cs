using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6_4.Domain.Common
{
    public interface IModifiedOn
    {
        public string? ModifiedByUserId { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
