using System;

namespace Circle
{
  public class Program
  {
    static void Main(string[] args)
    {
      string triangleQuality = "";
      int sidelength1;
      int sidelength2;
      int sidelength3;
      sidelength1 = Convert.ToInt16(Console.ReadLine());
      sidelength2 = Convert.ToInt16(Console.ReadLine());
      sidelength3 = Convert.ToInt16(Console.ReadLine());

      // Determine triangle type
      if (sidelength1 == sidelength2 || sidelength1 == sidelength3 || sidelength2 == sidelength3)
      {
        triangleQuality += "Isosceles";
      }
      if (sidelength1 != sidelength2 && sidelength1 != sidelength3 && sidelength2 != sidelength3)
      {
        triangleQuality += "Scalene";
      }

      // Check for right-angled triangle using Pythagorean theorem
      int[] sides = { sidelength1, sidelength2, sidelength3 };
      Array.Sort(sides);
      if (sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1])
      {
        triangleQuality += "Right Angle";
      }

      // Use a switch statement to determine the final triangle quality
      switch (triangleQuality)
      {
        case "IsoscelesRight Angle":
          triangleQuality = "Triangle is an isosceles right angled triangle";
          break;
        case "ScaleneRight Angle":
          triangleQuality = "Triangle is a scalene right angled triangle";
          break;
        default:
          triangleQuality = "Not a triangle";
          break;
      }

      Console.WriteLine(triangleQuality);
    }
  }
}