using System;

namespace MathGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many turns you need to play?");
            int turns = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < turns; i++)
            {
                Console.WriteLine("Please enter the operation you need to do");
                Console.WriteLine("1.Sum 2.Substract 3.Multiply 4.Division");
                int playerChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the first number");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                switch (playerChoice)
                {
                    case 1:
                        int sumOfTwoNumbers = firstNumber + secondNumber;
                        Console.WriteLine(sumOfTwoNumbers);
                        break;
                    case 2:
                        int substractionOfTwoNumbers = firstNumber - secondNumber;
                        Console.WriteLine(substractionOfTwoNumbers);
                        break;
                    case 3:
                        int multiplicationOfTwoNumbers = firstNumber * secondNumber;
                        Console.WriteLine(multiplicationOfTwoNumbers);
                        break;
                    case 4:
                        if (firstNumber % secondNumber == 0)
                        {
                            Console.WriteLine(firstNumber / secondNumber);

                        }
                        else
                        {
                            Console.WriteLine("Division gives non integer answer");

                        }
                        break;
                }
            }
        }
    }
}