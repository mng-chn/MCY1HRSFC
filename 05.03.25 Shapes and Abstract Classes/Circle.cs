using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._25_Shapes_and_Abstract_Classes
{
    internal class Circle:Shape
    {
        public double Radius { private set; get; }
        public Circle (double radius):base(1)
        {
            Radius = radius;
        }
        public override double Calculate_Area()
        {
            return Radius * Radius * Math.PI;
        }
        public override double Calculate_Perimeter()
        {
            return Radius*2*Math.PI;
        }
        public override void draw()
        {
            Console.WriteLine("Drawing circle...");
        }
    }
}
