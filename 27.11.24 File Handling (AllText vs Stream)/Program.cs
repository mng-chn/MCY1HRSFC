using System;
using System.IO;

namespace _27._11._24_File_Handling__AllText_vs_Stream_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\mc166476\source\repos\ConsoleApp1\bin\Debug\net8.0\File.txt";
            string username;
            string password;
            string answer;

            bool continue_ = true;
            while (continue_)
            {
                Console.Write("Username: ");
                username = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();
                File.AppendAllText(fileName, ($"|\t{username}\t|\t{password}\t|\n"));

                Console.Write("Continue? (Y/N): ");
                answer = Console.ReadLine();
                if (answer == "N")
                {
                    continue_ = false;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Contents of file:");
            Console.WriteLine(File.ReadAllText(fileName));
        }
    }
}
