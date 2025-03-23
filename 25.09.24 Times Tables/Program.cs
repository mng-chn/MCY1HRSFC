namespace _25._09._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt16(Console.ReadLine());
            int Max = 12;

            for (int i = 0+1; i < Max+1; i++)
            {
                Console.WriteLine($"{i} x {number} = {i*number}");
            }
        }
    }
}
