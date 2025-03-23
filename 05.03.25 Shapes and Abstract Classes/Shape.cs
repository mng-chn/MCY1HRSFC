using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._25_Shapes_and_Abstract_Classes
{
    public abstract class Shape
    {
        protected int number_of_sides;
        public int Sides
            { get { return number_of_sides; } }
        public Shape (int sides)
        {
            number_of_sides = sides;
        }
        public abstract double Calculate_Area();
        public abstract double Calculate_Perimeter();
        public abstract void draw();
    }
}
