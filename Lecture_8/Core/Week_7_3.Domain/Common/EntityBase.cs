using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7_3.Domain.Common
{
    public class EntityBase<TKey> : ICreatedByEntity, IModifiedByEntity, IDeletedByEntity
    {
        public TKey Id { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset? ModifiedOn { get; set; }

        public DateTimeOffset? DeletedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
