using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Base;

namespace Test
{
    public class Triangle : Figure
    {
        private readonly (int, int, int) _sides;

        public Triangle((int, int, int) sides)
        {
            Type = "Triangle";
            _sides = sides;
        }

        public override string Type { get; }

        /// <summary>
        /// Формула Герона для вычисления площади треугольника
        /// </summary>
        /// <returns></returns>
        public override double GetSquare()
        {
            var p = (_sides.Item1 + _sides.Item2 + _sides.Item3) / 2;

            var result = p * (p - _sides.Item1) * (p - _sides.Item2) * (p - _sides.Item3);

            return result * result;

        }
    }
}
