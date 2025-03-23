namespace _04._11._24_Coloured_Triangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // R = red, G = green, B = blue
            string startingRow = "GGRBGRBR";//Console.ReadLine(); // e.g GGRBGRBR
            string nextRow;

            string currentRow = startingRow;
            string colour1;
            string colour2;
            string colour3;

            while (currentRow.Length > 0)
            {
                Console.WriteLine(currentRow);
                nextRow = string.Empty;
                for (int i = 0; i < currentRow.Length - 1; i++)
                {
                    colour1 = Convert.ToString(currentRow[i]);
                    colour2 = Convert.ToString(currentRow[i + 1]);

                    if (colour1 != colour2)
                    {
                        colour3 = colour1+colour2; // instead: if (colour3 == "RG" || colour3 == "GR") {nextRow += "B"}
                        if (colour3 == "RG")       //          if (colour3 == "RB" || colour3 == "BR") {nextRow += "G"}
                        {                          //          if (colour3 == "BG" || colour3 == "GB") {nextRow += "R"}
                            nextRow += "B";
                        }
                        if (colour3 == "RB")
                        {
                            nextRow += "G";
                        }
                        if (colour3 == "GR")
                        {
                            nextRow += "B";
                        }
                        if (colour3 == "GB")
                        {
                            nextRow += "R";
                        }
                        if (colour3 == "BR")
                        {
                            nextRow += "G";
                        }
                        if (colour3 == "BG")
                        {
                            nextRow += "R";
                        }

                    }
                    else
                    {
                        nextRow += colour1;
                    }
                }
                currentRow = nextRow;
            }
        }
    }
}
