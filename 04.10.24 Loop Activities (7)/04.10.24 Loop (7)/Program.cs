namespace _04._10._24_Loop__7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] listSquaresFound;
            int numberOfSquaresFound = listSquaresFound.Length;
            int n = 0;
            int total = 0;
            double squareroot = 0;
            int squareCount = 0;

            while (numberOfSquaresFound < 3)
            {
                total = 0;
                for (int i = 0; i < n; i++)
                {
                    total += i;
                }
                Console.WriteLine($"{n}th triangular number is {total}");

                squareroot = Math.Sqrt(total);
                Console.WriteLine($"{squareroot} : \t {Convert.ToInt32(squareroot)}");
                if (squareroot == Convert.ToInt32(squareroot))
                {
                    listSquaresFound[squareCount] = total;
                    squareCount++;
                }
                n++;
                numberOfSquaresFound = listSquaresFound.Length;
        }
    }
}
