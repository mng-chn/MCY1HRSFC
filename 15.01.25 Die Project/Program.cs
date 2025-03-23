namespace _15._01._25_Die_Project
{
    public class Dice
    {

        // Attributes //
        public int value;
        public int sides;
        Random rnd = new Random();


        // Constructor Method //
        public Dice(int numSides)
        {
            sides = numSides;
            value = rnd.Next(sides) + 1;
        }

        // Methods //
        public int GetValue()
        {
            return value;
        }
        public void Roll()
        {
            value = rnd.Next(sides) + 1;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice(6);

            //dice.Roll();

            Console.WriteLine(dice.GetValue());
        }
    }
}
