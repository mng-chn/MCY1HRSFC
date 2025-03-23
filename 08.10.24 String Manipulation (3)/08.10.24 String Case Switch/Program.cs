namespace _08._10._24_String_Case_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = string.Empty;
            string caseSwitchedString = string.Empty;


            Console.Write("Enter string: ");
            inputString = Console.ReadLine();

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == char.ToUpper(inputString[i]))
                {
                    caseSwitchedString += char.ToLower(inputString[i]);
                }
                else
                {
                    caseSwitchedString += char.ToUpper(inputString[i]);
                }
            }
            Console.WriteLine(caseSwitchedString);
        }
    }
}
