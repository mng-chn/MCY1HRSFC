namespace _08._10._24_Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = string.Empty;
            string reverseString = string.Empty;


            Console.Write("Enter string: ");
            inputString = Console.ReadLine();

            for (int i = 0; i < inputString.Length; i++)
            {
                reverseString += inputString[inputString.Length - 1 - i];
            }

            Console.WriteLine(reverseString);
        }
    }
}
