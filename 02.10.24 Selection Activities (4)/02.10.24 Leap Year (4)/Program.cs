namespace _02._10._24_Leap_Year__4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            int year;

            while (continueProgram)
            {

                year = Convert.ToInt32(Console.ReadLine());

                if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year.");
                }

            }
        }
    }
}
