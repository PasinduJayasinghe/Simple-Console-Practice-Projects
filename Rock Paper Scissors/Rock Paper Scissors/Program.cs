using System;
using System.Diagnostics;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RockPaperScissors ");
            Random random = new Random();
            int enemyScore = 0;
            int playerScore = 0;

            while (enemyScore != 3 && playerScore != 3)
            {
                Console.WriteLine("Player Score" + playerScore + "Enemy Score" + enemyScore);
                Console.WriteLine("Please enter r for rock,p for paper, anything else for scissors");
                string playerChoice = Console.ReadLine();

                int enemyChoice = random.Next(0, 3);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy choose rock");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie");
                            break;
                        case "p":
                            Console.WriteLine("Player wins");
                            playerScore = playerScore + 1;
                            break;
                        default:
                            Console.WriteLine("Enemy wins");
                            enemyScore = enemyScore + 1;
                            break;
                    }


                }
                else if (enemyChoice == 1) 
                {
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy wins");
                            enemyScore += 1;
                            break;
                        case "p":
                            Console.WriteLine("Tie");
                            break;
                        default:
                            Console.WriteLine("Player wins");
                            playerScore += 1;
                            break;
                    }

                }
                else
                {
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player wins");
                            playerScore=playerScore + 1;
                            break;
                        case "p":
                            Console.WriteLine("Enemy wins");
                            enemyScore+=1;
                            break;
                        default:
                            Console.WriteLine("Tie");
                            break ;
                    }
                }
                if (playerScore == 3)
                {
                    Console.WriteLine("Player Wins");
                }
                else if(enemyScore==3)
                {
                    Console.WriteLine("Enemy wins");
                }
                else
                {
                    Console.WriteLine("No one won yet");
                }
            }

        }

    }
}