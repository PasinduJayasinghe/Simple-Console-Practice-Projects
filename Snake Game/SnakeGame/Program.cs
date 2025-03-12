using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeGame;

namespace SnakeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coord gridDimension = new Coord(50, 20);
            Coord snakePos = new Coord(10, 1);
            Random rand = new Random();
            Coord appleCoord = new Coord(rand.Next(1, gridDimension.X - 1), rand.Next(1, gridDimension.Y - 1));
            int frameDelay = 100;
            Direction movementDirection = Direction.Down;

            List<Coord> snakePosHistory = new List<Coord>();
            int taillength = 1;
            int score = 0;



            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Score is {score}");
                snakePos.ApplyMovementDirection(movementDirection);
                for (int y = 0; y < gridDimension.Y; y++)
                {
                    for (int x = 0; x < gridDimension.X; x++)
                    {
                        Coord currentCoord = new Coord(x, y);

                        if (snakePos.Equals(currentCoord)||snakePosHistory.Contains(currentCoord))
                        {
                            Console.Write("*");
                        }
                        else if (appleCoord.Equals(currentCoord))
                        {
                            Console.Write("a");
                        }
                        else if (x == 0 || y == 0 || x == gridDimension.X - 1 || y == gridDimension.Y - 1)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                if (snakePos.Equals(appleCoord))
                {
                    taillength++;
                    score++;
                    appleCoord = new Coord(rand.Next(1, gridDimension.X - 1), rand.Next(1, gridDimension.Y - 1));
                }
                else if (snakePos.X == 0 || snakePos.Y == 0 || snakePos.X == gridDimension.X - 1 || snakePos.Y == gridDimension.Y - 1||snakePosHistory.Contains(snakePos)) {
                    score = 0;
                    taillength = 1;
                    snakePos = new Coord(10, 1);
                    snakePosHistory.Clear();
                    movementDirection=Direction.Down;
                    continue;
                }
                snakePosHistory.Add(new Coord(snakePos.X, snakePos.Y));
                if(snakePosHistory.Count > taillength)
                {
                    snakePosHistory.RemoveAt(0);
                }
                DateTime dateTime = DateTime.Now;

                while ((DateTime.Now - dateTime).Milliseconds < frameDelay)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKey key = Console.ReadKey().Key;
                        switch (key)
                        {
                            case ConsoleKey.LeftArrow:
                                movementDirection = Direction.Left;
                                break;
                            case ConsoleKey.RightArrow:
                                movementDirection = Direction.Right; break;
                            case ConsoleKey.UpArrow:
                                movementDirection = Direction.Up; break;
                            case ConsoleKey.DownArrow:
                                movementDirection = Direction.Down; break;
                        }
                    }
                }
            }
        }
    }
}
