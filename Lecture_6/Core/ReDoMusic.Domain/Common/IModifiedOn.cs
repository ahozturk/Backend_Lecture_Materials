using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoMusic.Domain.Common
{
    public interface IModifiedOn
    {
        public DateTime? ModifiedOn { get; set; }
    }
}
