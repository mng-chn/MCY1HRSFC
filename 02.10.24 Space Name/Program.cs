namespace _02._10._24_Space_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string townName = Console.ReadLine();
            string monthName = Console.ReadLine();

            string spacePrenom = string.Empty;
            string spaceSurname = string.Empty;

            spacePrenom = lastName.Substring(0,3) + firstName.Substring(0,2).ToLower();
            spaceSurname = townName.Substring(0,3) + monthName.Substring(0,2).ToLower();

            Console.WriteLine($"{spacePrenom} {spaceSurname}");
        }
    }
}
