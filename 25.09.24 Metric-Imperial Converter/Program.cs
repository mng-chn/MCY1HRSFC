using System.Drawing;

namespace _25._09._24_Metric_Imperial_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double PoundToKG = 0.4536; //multiplier for 1 pound -> kg
            Double PoundToStones = 0.0714286;
            Double PoundToOunces = 16;


            for (Double i = 0.0; i < 21; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Pound     kg     Stones     Ounces");
                }
                else
                {
                    Console.WriteLine($"{i}     {Math.Round(i * PoundToKG, 4)}     {Math.Round(i*PoundToStones, 4)}     {Math.Round(i*PoundToOunces), 4}");
                }
            }
        }
    }
}
