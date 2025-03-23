namespace _06._11._24_Calculator__Functions_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator program\n");

            bool NoQuit = true;
            string YesQuit = null;

            while (NoQuit)
            {
                Calculator();

                Console.WriteLine("\nAre you done? (yes,no)");
                YesQuit = Console.ReadLine();
                if (YesQuit == "yes")
                {
                    NoQuit = false;
                }
            }
        }

        static void Calculator()
        {

            // Ask the user for two number and store them as floats
            Console.WriteLine("Enter the first number: ");
            float number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            float number2 = float.Parse(Console.ReadLine());

            DisplayMenu();

            // Ask for the menu option
            int menuOption = int.Parse(Console.ReadLine());

            Console.Write("\n The result is: ");

            // Perform a subroutine based on the menu option
            switch (menuOption)
            {
                case 1:
                    Console.WriteLine(Addition(number1, number2));
                    break;
                case 2:
                    Console.WriteLine(Subtraction(number1, number2));
                    break;
                case 3:
                    Console.WriteLine(Multiplication(number1, number2));
                    break;
                case 4:
                    Console.WriteLine(Division(number1, number2));
                    break;
                case 5:
                    Console.WriteLine(FloorDivison(number1, number2));
                    break;
                case 6:
                    Console.WriteLine(Modulus(number1, number2));
                    break;
                default:
                    Console.WriteLine("Please choose a valid option");
                    break;
            }

        }


        static void DisplayMenu()
        {
            // Output the menu options
            Console.WriteLine("\nEnter the menu number of the calculation to perform: ");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Floor Divison");
            Console.WriteLine("6 - Modulus\n");

        }


        // The addition procedure has two floats as parameters, adds them together and outputs the result
        static float Addition(float num1, float num2)
        {
            return (num1 + num2);
        }
        static float Subtraction(float num1, float num2)
        {
            return (num1 - num2);
        }
        static float Multiplication(float num1, float num2)
        {
            return (num1 * num2);
        }
        static float Division(float num1, float num2)
        {
            return (num1 / num2);
        }
        static float FloorDivison(float num1, float num2)
        {
            return Convert.ToInt16(num1 / num2);
        }
        static float Modulus(float num1, float num2)
        {
            return (num1 % num2);
        }
    }
}
