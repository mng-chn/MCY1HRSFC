using System.Runtime.InteropServices;

namespace _02._10._24_String_Checking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string String = "I am going to check every word of this sentence for the keywords";
            
            string[] words = String.Split(' '); //split string
            //put words into array
            
            foreach (string word in words)  //iterate through array
            {
                switch (word)
                {
                    case "check":
                        break;
                    case "word":
                        break;
                    case "sentence":
                        break;
                }
            }
            
            //find keywords: check word sentence
            //print keywords in different colour
        }
    }
}
