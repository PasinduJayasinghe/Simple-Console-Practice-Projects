﻿using System;
namespace HangManGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "hello";
            int maxLives = 7;
            int currentLives = maxLives;
            bool win = false;

            List<char> guessedLetters = new List<char>();

            while (currentLives > 0 && !win)
            {
                foreach (char c in word)
                {
                    if (guessedLetters.Contains(c))
                    {
                        Console.Write(c);
                    }
                    else
                    {
                        Console.Write("_");
                    }
                }
                Console.WriteLine("\nPlease guess a letter");
                Console.WriteLine($"{currentLives} / {maxLives} lives remaining");
                char guess = Convert.ToChar(Console.ReadLine());

                if (word.Contains(guess) && !guessedLetters.Contains(guess))
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                    currentLives--;
                }
                guessedLetters.Add(guess);

                bool wordComplete = true;
                foreach (char c in word)
                {
                    if (!guessedLetters.Contains(c))
                    {
                        wordComplete = false;
                    }
                }
                win = wordComplete;

            }
            if (win) { Console.WriteLine("You won"); }
            else
            {
                Console.WriteLine("You lose");
            }

        }
    }
}