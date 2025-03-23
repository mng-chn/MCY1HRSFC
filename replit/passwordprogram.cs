using System;

namespace PasswordValidation
{
  public class Program
  {
    static void Main(string[] args)
    {
      string StoredPassword = "abcdefg";
      string inputPassword = "";
      int attempts = 0; // maximum attempts: 3

      while (StoredPassword != inputPassword && attempts > 3)
      {
        Console.Write("Input password: ");
        inputPassword = Console.ReadLine();
        attempts++;
      }
      switch (inputPassword)
      {
      case StoredPassword:
        Console.WriteLine("Access granted");
        break;
      default:
        Console.WriteLine("Access denied");
        break;
      }
    }
  }
}