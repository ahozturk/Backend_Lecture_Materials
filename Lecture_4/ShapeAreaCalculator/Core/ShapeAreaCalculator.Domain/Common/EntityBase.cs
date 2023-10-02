using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Domain.Common
{
    public class EntityBase<TKey> : IModifiedOn
    {
        public TKey Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
