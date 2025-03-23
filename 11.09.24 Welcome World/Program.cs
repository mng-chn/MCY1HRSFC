namespace welcome_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            int age = 0;

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());

            //different ways of displaying WriteLine
            Console.WriteLine($"Hello, {name}! You are {age} years old.");                       //Interpollation
            Console.WriteLine("Hello, " + name + "! You are " + age + " years old.");            //Concatenation
            Console.WriteLine("Hello, {0}! You are {1} years old.",name,age);                    //sum placeholder and list

            Console.ReadLine();
        }
    }
}
