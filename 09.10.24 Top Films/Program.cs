namespace _09._10._24_Top_Films
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            •Create a string array with your top 5 films (use the template code above)

            •Display each of the films using a foreach loop

            •Sort the array into ascending order using Array.Sort() then display the elements

            •Reverse the array into descending order using Array.Reverse() then display the elements

            •Replace the last film from the reversed array with another film then display the elements
            */

            string[] films = { "Film1", "Movie2", "Play3", "Musical4", "AnimatedShort5" };

            foreach (string film in films)
            {
                Console.WriteLine(film);
            }

            Console.WriteLine();
            Array.Sort(films);
            foreach (string film in films)
            {
                Console.WriteLine(film);
            }

            Console.WriteLine();
            Array.Reverse(films);
            foreach (string film in films)
            {
                Console.WriteLine(film);
            }

            Console.WriteLine();
            films[4] = "filmslis";
            foreach (string film in films)
            {
                Console.WriteLine(film);
            }
        }
    }
}
