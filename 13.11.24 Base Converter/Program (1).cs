using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _13._11._24_Base_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();

            int option = Convert.ToInt16(Console.ReadLine());

            string outputNum = string.Empty;

            if (option == 5)
            {
                //return;
            }

            else if (option % 2 == 1)
            {
                int inputNum = Convert.ToInt16(Console.ReadLine());
                if (option == 1)
                {
                    outputNum = DecimalToBinary(inputNum);
                }
                else if (option == 3)
                {
                    outputNum = DecimalToHexadecimal(inputNum);
                }
            }

            else
            {
                string inputNum = Console.ReadLine();
                if (option == 2)
                {
                    outputNum = BinaryToDecimal(inputNum).ToString();
                }
                else if (option == 4)
                {
                    outputNum = HexadecimalToDecimal(inputNum).ToString();
                }
                else
                {
                    Console.WriteLine("Please enter a option.");
                }
            }

            Console.WriteLine(outputNum);
        }


        static void DisplayMenu() { Console.WriteLine("What function would you like to use?\n -(1) Decimal to binary\n -(2) Binary to decimal\n -(3) Decimal to hexadecimal\n -(4) Hexadecimal to decimal\n -(5) Exit"); }

        static string DecimalToBinary(int decimal_)
        {
            string binary = string.Empty;
            int bit = 0;

            while (decimal_ > 0)
            {
                bit = decimal_ % 2;
                binary = bit.ToString() + binary;
                decimal_ = decimal_ / 2;
            }
            return binary;
        }

        static int BinaryToDecimal(string binary)
        {
            int decimal_ = 0;
            int power = 1;
            for (int i = binary.Length - 1; i > -1; i--)
            {
                if (binary[i] == '1')
                {
                    decimal_ += power;
                }
                power *= 2;
            }
            return decimal_;
        }

        static string DecimalToHexadecimal(int decimal_)
        {
            string hexadecimal = string.Empty;
            char character;

            while (decimal_ > 0)
            {
                character = NumberToAlpha(decimal_ % 16);
                hexadecimal = character + hexadecimal;
                decimal_ = decimal_ / 16;
            }
            return hexadecimal;
        }
        static int HexadecimalToDecimal(string hexadecimal)
        {
            int decimal_ = 0;
            int power = 1;
            int digit = 1;
            for (int i = hexadecimal.Length - 1; i > -1; i--)
            {
                digit = AlphaToNumber(hexadecimal[i]);
                if (digit == 0) { }
                else { decimal_ += power*digit; }
                power *= 16;
            }
            return decimal_;
        }
        static int AlphaToNumber(char character)
        {
            int number = 0;
            if ((char)character < 58) { number = (int)(character)-48; }
            else if (character == 'A') { number = 10; }
            else if (character == 'B') { number = 11; }
            else if (character == 'C') { number = 12; }
            else if (character == 'D') { number = 13; }
            else if (character == 'E') { number = 14; }
            else if (character == 'F') { number = 15; }
            return number;
        }

        static char NumberToAlpha(int number)
        {
            char character = '0';
            if (number < 10) { character = number.ToString()[0]; }
            else if (number == 10) { character = 'A'; }
            else if (number == 11) { character = 'B'; }
            else if (number == 12) { character = 'C'; }
            else if (number == 13) { character = 'D'; }
            else if (number == 14) { character = 'E'; }
            else if (number == 15) { character = 'F'; }
            return character;
        }
    }
}

/*
=== Different method for converting letters to decimal ===

print:  0 --> 9      A -->  F
ascii: 48 -->57     65 --> 70

paste from binary to decimal function:

        static int BinaryToDecimal(string binary)
        {
            int decimal_ = 0;
            int power = 1;
            for (int i = binary.Length - 1; i > -1; i--)
            {
                if (binary[i] == '1')
                {
                    decimal_ += power;
                }
                power *= 2;
            }
            return decimal_;
        }

edit block in for loop:

        if (hex[i] >= '0' && hex[i] <= '9')
        {
            decimal_ += (int)hex[i] - 48;
        }
        else // for letters
        {
            decimal_ += (int)hex[i] - 65 + 10;
        }
        power *= 2;

*/