namespace _01._10._24_Maths_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Maths Quiz : random numbers, 10 qeustions, keep score

            //initialised variables
            Random random = new Random();
            double num1 = 0;
            double num2 = 0;
            int mathOperatorIndex;
            double answer = 0;
            double correctAnswer = 0;
            bool isCorrect = false;
            int score = 0;
            string grade = "0";
            //--------------------------

            //for loop to produce 10 questions
            for (int i = 0; i < 10; i++)
            {
                isCorrect = false;
                num1 = random.Next(1, 10);                     // first number is randomized every iteration
                num2 = random.Next(1, 10);                     // second number is randomized every iteration
                mathOperatorIndex = random.Next(1, 6);          // number to decide which math operator to use is randomized

                switch (mathOperatorIndex)
                {
                    case 1:
                        Console.Write($"{num1} + {num2} = ");
                        answer = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Answer is ", num1 + num2);
                        correctAnswer = Math.Round(num1 + num2, 2);
                        if (answer == correctAnswer)
                        {
                            isCorrect = true;
                        }
                        break;

                    case 2:
                        Console.Write($"{num1} - {num2} = ");
                        answer = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Answer is ", num1 - num2);
                        correctAnswer = Math.Round(num1 - num2, 2);
                        if (answer == correctAnswer)
                        {
                            isCorrect = true;
                        }
                        break;

                    case 3:
                        Console.Write($"{num1} * {num2} = ");
                        answer = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Answer is ", num1 * num2);
                        correctAnswer = Math.Round(num1 * num2, 2);
                        if (answer == correctAnswer)
                        {
                            isCorrect = true;
                        }
                        break;

                    case 4:
                        Console.Write($"{num1} / {num2} = ");
                        answer = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Answer is ", num1 / num2);
                        correctAnswer = Math.Round(num1 / num2, 2);
                        if (answer == correctAnswer)
                        {
                            isCorrect = true;
                        }
                        break;

                    case 5:
                        Console.Write($"{num1} % {num2} = ");
                        answer = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(num1 % num2);
                        correctAnswer = Math.Round(num1 % num2, 2);
                        if (answer == correctAnswer)
                        {
                            isCorrect = true;
                        }
                        break;
                }

                if (isCorrect)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
                //fill in: print equation to answer, decide whether answer is correct, store score
            }
            //--------------------------

            //adds a grade depending on score
            switch (score)
            {
                case 10:
                    grade = "A";
                    break;
                case > 5:
                    grade = "B";
                    break;
                case > 0:
                    grade = "C";
                    break;
            }
            //---------------------------
            //end result: print score and grade
            Console.WriteLine(score);
            Console.WriteLine(grade);
        }
    }
}
