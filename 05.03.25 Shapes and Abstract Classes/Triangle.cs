using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._25_Shapes_and_Abstract_Classes
{
    internal class Triangle:Shape
    {
        public double SideLength { private set; get; }
        public Triangle(int sides):base(3)
        {
            SideLength = sides;
        }
        public override double Calculate_Area()
        {
            return Math.Pow(SideLength,2)/2;
        }
        public override double Calculate_Perimeter()
        {
            return SideLength * Sides;
        }
        public override void draw()
        {
            Console.WriteLine("Drawing triangle...");
        }
    }
}
