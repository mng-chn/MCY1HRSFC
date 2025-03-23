namespace _02._10._24_Roots_of_a_Quadratic__3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double discriminant;
            double root1;
            double root2;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                root1 = Math.Round((-b + Math.Sqrt(b * b - 4 * a * c) / (2 * a)), 2);
                root2 = Math.Round((-b - Math.Sqrt(b * b - 4 * a * c) / (2 * a)), 2);
                Console.WriteLine($"{root1}   {root2}");
            }
            else if (discriminant == 0)
            {
                root1 = Math.Round( (-b / (2 * a)), 2);
                Console.WriteLine(root1);
            }
            else
            {
                Console.WriteLine("No solution. Imaginary roots.");
            }
        }
    }
}
