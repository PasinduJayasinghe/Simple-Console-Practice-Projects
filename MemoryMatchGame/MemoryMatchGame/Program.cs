namespace MemoryMatchGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            int row = 3;
            int col = 3;

            int asciiStart = 65;
            char[] grid = new char[row * col];

            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = Convert.ToChar(asciiStart + i / 2);
            }
            Random random = new Random();
            random.Shuffle(grid);

            string[] playingGrid = new string[row * col];

            for (int i = 0; i < playingGrid.Length; i++)
            {
                playingGrid[i] = (i + 1).ToString();
            }

            int matches = 0;
            bool gameWon=false;

            while (!gameWon) {
                printPlayingGrid();
                Console.WriteLine("Please select a number");
                int choice1=Convert.ToInt32(Console.ReadLine());
                playingGrid[choice1 - 1] = grid[choice1 - 1].ToString();
                printPlayingGrid();
                

                Console.WriteLine("Please enter your second number");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                playingGrid[choice2 - 1] = grid[choice2 - 1].ToString();
                printPlayingGrid();
             

                if (grid[choice1 - 1] == grid[choice2 - 1]) {

                    Console.WriteLine("Match");
                    matches++;
                    if (matches == (row * col) / 2)
                    {
                        gameWon = true;
                    }
                
                }
                else
                {
                    Console.WriteLine("No match");
                    playingGrid[choice2-1]=choice2.ToString();
                    playingGrid[choice1-1]=choice1.ToString();
                }

                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("You won");

            printPlayingGrid();
            void printPlayingGrid()
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(playingGrid[col*i+j]+" | ");
                    }
                    Console.WriteLine();

                }



            }
        }
    }
}