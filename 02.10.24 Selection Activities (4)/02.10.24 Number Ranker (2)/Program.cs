namespace _02._10._24_Number_Ranker__2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());  
            int[] arr = {num1, num2, num3};
            Array.Sort(arr);

            Console.WriteLine("Largest number: {0}",arr[2]);
            Console.WriteLine("Smallest number: {0}",arr[0]);

            Console.WriteLine();
            foreach (int i in arr) Console.WriteLine(i);
        }
    }
}
