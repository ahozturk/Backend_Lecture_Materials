using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Common
{
    internal class Person<TKey> : EntityBase<TKey>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
