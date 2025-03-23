namespace _08._10._24_Vowels_and_Consonants_in_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = string.Empty;
            int numConsonants = 0;
            int numVowels = 0;


            Console.Write("Enter string: ");
            inputString = Console.ReadLine().ToLower();

            foreach (char letter in inputString)
            {
                switch (letter)
                {
                    case 'e':
                        numVowels++;
                        break;
                    case 't':
                        numConsonants++;
                        break;
                    case 'a':
                        numVowels++;
                        break;
                    case 'o':
                        numVowels++;
                        break;
                    case 'i':
                        numVowels++;
                        break;
                    case 'n':
                        numConsonants++;
                        break;
                    case 's':
                        numConsonants++;
                        break;
                    case 'h':
                        numConsonants++;
                        break;
                    case 'r':
                        numConsonants++;
                        break;
                    case 'l':
                        numConsonants++;
                        break;
                    case 'd':
                        numConsonants++;
                        break;
                    case 'c':
                        numConsonants++;
                        break;
                    case 'u':
                        numVowels++;
                        break;
                    case 'f':
                        numConsonants++;
                        break;
                    case 'm':
                        numConsonants++;
                        break;
                    case 'w':
                        numConsonants++;
                        break;
                    case 'y':
                        numVowels++;
                        break;
                    case 'p':
                        numConsonants++;
                        break;
                    case 'g':
                        numConsonants++;
                        break;
                    case 'b':
                        numConsonants++;
                        break;
                    case 'v':
                        numConsonants++;
                        break;
                    case 'k':
                        numConsonants++;
                        break;
                    case 'x':
                        numConsonants++;
                        break;
                    case 'j':
                        numConsonants++;
                        break;
                    case 'q':
                        numConsonants++;
                        break;
                    case 'z':
                        numConsonants++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Number of consonants: {numConsonants} \t Number of vowels: {numVowels}");
        }
    }
}
