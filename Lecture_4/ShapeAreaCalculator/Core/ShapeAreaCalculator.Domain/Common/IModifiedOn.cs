using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Domain.Common
{
    internal interface IModifiedOn
    {
        public DateTimeOffset ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
