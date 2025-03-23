namespace _04._11._24_Roman_Numerals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = 0;
            string romanNumber = string.Empty;

            //decimalNumber = Convert.ToInt16(Console.ReadLine());


            for (int i = 0; i < 4000; i++)
            {
                Console.WriteLine(Convert.ToString(i));
                decimalNumber = i;
                romanNumber = string.Empty;

                while (decimalNumber > 999)
                {

                    romanNumber += "M";
                    decimalNumber -= 1000;

                }

                while (decimalNumber > 499)
                {
                    if (decimalNumber == 500)
                    {
                        romanNumber += "CM";
                        decimalNumber -= 900;
                    }
                    else
                    {
                        romanNumber += "D";
                        decimalNumber -= 500;
                    }

                }

                while (decimalNumber > 99)
                {

                    if (decimalNumber == 400)
                    {
                        romanNumber += "CD";
                        decimalNumber -= 400;
                    }
                    else
                    {
                        romanNumber += "C";
                        decimalNumber -= 100;
                    }

                }

                while (decimalNumber > 49)
                {
                    if (decimalNumber == 90)
                    {
                        romanNumber += "XC";
                        decimalNumber -= 90;
                    }
                    romanNumber += "L";
                    decimalNumber -= 50;

                }

                while (decimalNumber > 9)
                {


                    if (decimalNumber == 40)
                    {
                        romanNumber += "XL";
                        decimalNumber -= 40;
                    }
                    else
                    {
                        romanNumber += "X";
                        decimalNumber -= 10;
                    }

                }

                while (decimalNumber > 4)
                {

                    if (decimalNumber == 9)
                    {
                        romanNumber += "IX";
                        decimalNumber -= 9;
                    }
                    else
                    {
                        romanNumber += "V";
                        decimalNumber -= 5;
                    }

                }

                while (decimalNumber > 0)
                {

                    if (decimalNumber == 4)
                    {
                        romanNumber += "IV";
                        decimalNumber -= 4;
                    }
                    else
                    {
                        romanNumber += "I";
                        decimalNumber -= 1;
                    }

                }
                Console.WriteLine(romanNumber);

            }

            /*
            while (decimalNumber > 999)
            {

                romanNumber += "M";
                decimalNumber -= 1000;

            }

            while (decimalNumber > 499)
            {
                if (decimalNumber == 500)
                {
                    romanNumber += "CM";
                    decimalNumber -= 900;
                }
                else
                {
                    romanNumber += "D";
                    decimalNumber -= 500;
                }

            }

            while (decimalNumber > 99)
            {

                if (decimalNumber == 400)
                {
                    romanNumber += "CD";
                    decimalNumber -= 400;
                }
                else
                {
                    romanNumber += "C";
                    decimalNumber -= 100;
                }                    

            }

            while (decimalNumber > 49)
            {
                if (decimalNumber == 90)
                {
                    romanNumber += "XC";
                    decimalNumber -= 90;
                }
                    romanNumber += "L";
                    decimalNumber -= 50;

            }

            while (decimalNumber > 9)
            {

                   
                if (decimalNumber == 40)
                {
                    romanNumber += "XL";
                    decimalNumber -= 40;
                }
                else
                {
                    romanNumber += "X";
                    decimalNumber -= 10;
                }

            }

            while (decimalNumber > 4)
            {

                if (decimalNumber == 9)
                {
                    romanNumber += "IX";
                    decimalNumber -= 9;
                }
                else
                {
                    romanNumber += "V";
                    decimalNumber -= 5;
                }

            }

            while (decimalNumber > 0)
            {

                if (decimalNumber == 4)
                {
                    romanNumber += "IV";
                    decimalNumber -= 4;
                }
                else
                {
                    romanNumber += "I";
                    decimalNumber -= 1;
                }

            }
            Console.WriteLine(romanNumber);


            */
            Console.ReadLine(); Console.ReadLine(); Console.ReadLine();
        }
    }
}
