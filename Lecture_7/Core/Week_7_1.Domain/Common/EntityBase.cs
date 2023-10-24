using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7_1.Domain.Common
{
    public class EntityBase<TKey> : ICreatedByEntity, IModifiedByEntity
    {
        public TKey Id { get; set; }

        public DateTime CreatedOn { get; set; }
        public string CreatedByUserId { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedByUserId { get; set; }
    }
}
