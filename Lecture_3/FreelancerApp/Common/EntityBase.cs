using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3.Common
{
    internal class EntityBase<TKey>
    {
        public TKey Id { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
