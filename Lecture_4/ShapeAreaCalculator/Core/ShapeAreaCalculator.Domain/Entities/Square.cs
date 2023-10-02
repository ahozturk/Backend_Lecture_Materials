using ShapeAreaCalculator.Domain.Abstract;
using ShapeAreaCalculator.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Domain.Entities
{
    public class Square : Shape
    {
        public decimal OneSide { get; set; }

        public Square(decimal oneSide)
        {
            Type = "Square";
            OneSide = oneSide;
        }

        public override decimal GetArea()
        {
            return OneSide * OneSide;
        }
    }
}
