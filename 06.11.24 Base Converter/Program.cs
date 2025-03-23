namespace _06._11._24_Base_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numInput;
            string numOutput;
            int numBase;
            bool ToDecimal = true;
            string input = string.Empty;

            do
            {
                Console.Write("Do you want to convert to(0) or from(1) decimal?");
                input = Console.ReadLine();
                if (input == "0") { ToDecimal = true; } else if (input == "1") { ToDecimal = false; } else { Console.WriteLine("Enter option again"); }
            }
            while (input != "0" && input != "1");

            Console.Write("\nEnter number: "); numInput = Convert.ToInt32(Console.Read());
            Console.Write("Enter base: "); numBase = 2;//Convert.ToInt16(Console.Read());

            if (ToDecimal)
            {
                Console.WriteLine(ConvertToDecimal(numInput,numBase));
            }
            else
            {
                Console.WriteLine(ConvertToOtherBase(numInput,numBase));
            }

        }

        static string ConvertToDecimal(int Input, int Base) //only works with binary
        {
            string digits = string.Empty;
            int digit;
            int power = 1;
            for (int i = (Input.Length() - 1); i > 0; i--)
            {
                if (Input[i] = ”1”)
                {
                    digits += power;
                    power *= Base;
                }
            }
            return digits;
        }

        static string ConvertToOtherBase(int Input, int Base)
        {
            string digits = string.Empty;
            int digit;

            while (Input > 0)
            {
                digit = Input % Base;
                digits = bit.ToString() + digit;
                Input = Input / Base;
            }
            return digits;
        }
    }
}
