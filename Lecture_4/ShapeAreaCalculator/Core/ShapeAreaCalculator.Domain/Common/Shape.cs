using ShapeAreaCalculator.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Domain.Common
{
    public abstract class Shape : EntityBase<Guid>, ISaveableShape
    {
        public string Type { get; set; }
        public abstract decimal GetArea();

        public string GetInfos()
        {
            return $"{Type} AREA: {GetArea()}";
        }
    }
}
