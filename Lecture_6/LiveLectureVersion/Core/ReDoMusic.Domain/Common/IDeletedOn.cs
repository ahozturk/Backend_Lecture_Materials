using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoMusic.Domain.Common
{
    public interface IDeletedOn
    {
        public DateTime? DeletedOn { get; set; }
    }
}
