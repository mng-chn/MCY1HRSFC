namespace _09._10._24_Subjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             •Ask the user for the number of subjects they currently study
             •Create an array with a length that matches the number of subjects
             •Use a loop to store each subject as an element in the array
             •Use another loop to output all the subjects entered

             Challenge: Allow the user to modify their subject choices.
             */
            Console.Write("How many subjects? : ");
            int numSubjects = Convert.ToInt16(Console.ReadLine());

            string[] subjects = new string[numSubjects];

            for (int i = 0; i < numSubjects; i++)
            {
                subjects[i] = Console.ReadLine();
            }

            foreach (string subject in subjects)
            {
                Console.WriteLine(subject);
            }
        }
    }
}
