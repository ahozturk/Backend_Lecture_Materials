using ShapeAreaCalculator.Domain.Abstract;
using ShapeAreaCalculator.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Domain.Entities
{
    internal class Triangle : Shape
    {
        public decimal Attitude { get; set; }
        public decimal Base { get; set; }

        public Triangle()
        {
            Type = "Triangle";
        }

        public override decimal GetArea()
        {
            return (Attitude * Base) / 2;
        }
    }
}
