namespace _11._09._24_Fernheit_Celsius_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 0;
            double celsius = 0;

            Console.WriteLine("Enter Farenheit measurement");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(fahrenheit);
            //Console.WriteLine(celsius);
            celsius = 5.0/9 * (fahrenheit-32);
            Console.WriteLine(Math.Truncate(celsius*100)/100);

        }
    }
}
