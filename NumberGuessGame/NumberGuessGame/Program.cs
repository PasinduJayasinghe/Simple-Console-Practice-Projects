using System;

namespace NumberGuessGame
{
	class Program
	{
		static void Main(string[] args) 
		{
			int randomNumber;
			Random random = new Random();

			Console.WriteLine("Welcome to the number guess game\n");
            Console.WriteLine("Rules : \n You need guess the correct number that equals to what computer generates \n If guessed " +
				"correctly, you get 1 point and you has 10 rounds\n finally your score will be shown\n" +
				"Your number needs to be between 0 and 11");
			Console.ReadKey();

			for (int i = 0; i < 10; i++) {
                Console.WriteLine("Enter your number");
				int playerNumber;
				String inputNumber = Console.ReadLine();
				playerNumber = (Convert.ToInt32(inputNumber));
                randomNumber = random.Next(1,11);
				Console.WriteLine("Random number from computer: "+randomNumber);
			}
			


        }
	}
}