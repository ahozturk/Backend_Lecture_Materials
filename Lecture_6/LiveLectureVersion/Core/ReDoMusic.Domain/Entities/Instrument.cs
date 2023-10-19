using ReDoMusic.Domain.Common;
using ReDoMusic.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoMusic.Domain.Entities
{
    public class Instrument : EntityBase<Guid>
    {
        public string Name { get; set; }
        public Brand Brand { get; set; } //Entity
        public string Model { get; set; }
        public Color Color { get; set; }
        public DateTime? ProductionYear { get; set; }
        public decimal Price { get; set; }

        //Category
    }
}
