using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Base;

namespace Test
{
    public class Circle : Figure
    {
        private readonly int _radius;

        public Circle(int radius)
        {
            Type = "Circle";
            _radius = radius;
        }

        public override string Type { get; }

        public override double GetSquare()
        {
            if (_radius == 0) return 0;

            return _pi * (_radius * _radius);
        }
    }
}
