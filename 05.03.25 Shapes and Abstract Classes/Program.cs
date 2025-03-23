namespace _05._03._25_Shapes_and_Abstract_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Create a Console application project named Shapes
             Add a new class Shape
             You can find the code of Shape class in slide 5
             Add some child classes Square, Circle, Rectangle
             You have an example of Square in slide 6
             Test your classes: slide 8 of the presentation
            */

            Shape[] shapes = new Shape[3];
            shapes[0] = new Square(2);
            shapes[1] = new Triangle(2);
            shapes[2] = new Circle(1);

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Type:");
                Console.WriteLine(shape.GetType()); Console.WriteLine();
                Console.WriteLine("Area");
                Console.WriteLine(shape.Calculate_Area()); Console.WriteLine();
                Console.WriteLine("Perimeter");
                Console.WriteLine(shape.Calculate_Perimeter()); Console.WriteLine();
                shape.draw();
            }
        }
    }
}
