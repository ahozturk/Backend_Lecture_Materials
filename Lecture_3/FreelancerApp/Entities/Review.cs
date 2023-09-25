using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture_3.Common;

namespace Lecture_3.Entities
{
    internal class Review : EntityBase<Guid>
    {
        public string? Text { get; set; }
        private int point;

        public int Point
        {
            get { return point; }
            set
            {
                if (value >= 1 && value <= 5)
                    point = value;
                throw new Exception("Point must be between 1-5");
            }
        }

        public Review(int point)
        {
            Point = point;
        }

        public Review(int point, string text)
        {
            Point = point;
            Text = text;
        }
    }
}
