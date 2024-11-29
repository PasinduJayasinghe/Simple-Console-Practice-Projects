using System;
using System.Diagnostics;

namespace DiceGame
{
	class Program
	{
		
		static void Main(string[] args)
		{ 
        int playerRandomNumber;
        int enemyAIRandomNumber;
		int playerScore = 0;
		int enemyAIScore = 0;

        Random random = new Random();
		
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Press a key to generate a number");
				Console.ReadKey();
                playerRandomNumber = random.Next(1, 7);
                Console.WriteLine("Player random number is "+ playerRandomNumber);

			    enemyAIRandomNumber = random.Next(1, 7);
				Console.WriteLine("Enemy AI random number is "+ enemyAIRandomNumber);

				if (playerRandomNumber > enemyAIRandomNumber)
				{
					Console.WriteLine("Player wins!\n");
					playerScore++;
					Console.WriteLine("Player Score\n " + playerScore);
					Console.WriteLine("Enemy AI Score\n " + enemyAIScore);
				}
				else if (playerRandomNumber < enemyAIRandomNumber)
				{
					Console.WriteLine("Enemy AI wins!\n");
					enemyAIScore++;
					Console.WriteLine("Player Score\n " + playerScore);
					Console.WriteLine("Enemy AI Score\n " + enemyAIScore);
				}
				else
				{
                    Console.WriteLine("Draw!\n");
                    Console.WriteLine("Player Score\n " + playerScore);
                    Console.WriteLine("Enemy AI Score\n "  + enemyAIScore);
                }

            }
			if (playerScore > enemyAIScore)
			{
				Console.WriteLine("Player Wins!");
			}
			else if (playerScore<enemyAIScore)
			{
                Console.WriteLine("EnemyAI Wins!");
            }
            else
            {
                Console.WriteLine("Draw!");
            }
        }

	}
}