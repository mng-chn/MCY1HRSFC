using System.Diagnostics.Metrics;

namespace _05._11._24_Decrypt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Working from left to right, after leaving the leftmost character alone, each character is replaced with the character produced by adding it to the character to its immediate left.

            string plainText = "ENCRYPT";
            string cipherText = plainText;

            char letter1;
            char letter2;
            int ASCIIcode;
            char newletter;


            for (int i = 1; i < cipherText.Length; i++)
            {
                letter1 = cipherText[i];
                letter2 = cipherText[i - 1];
                ASCIIcode = (int)letter1 + (int)letter2;

                if (ASCIIcode > 26)
                {
                    ASCIIcode = ASCIIcode - 26*(ASCIIcode/26);
                    newletter = (char)ASCIIcode;
                }
                else
                {
                    newletter = (char)ASCIIcode;
                }
                cipherText += newletter;
            }
            Console.WriteLine(plainText);
            Console.WriteLine(cipherText);
        }
    }
}
