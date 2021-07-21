using System;

namespace minesweepermilestone1
{
    class Program
    {
        static void Main(string[] args)
        {
            board game = new board(10);
            //printBoard(game); //Uncomment to Show Key

            bool endgame = false;

            while (endgame == false) 
            {
                //Ask the User for the Row and Column Number
                Console.Out.Write("What is the Row Number to Play?: ");
                int Row = int.Parse(Console.ReadLine());
                Console.Out.Write("What is the Column Number to Play?: ");
                int Column = int.Parse(Console.ReadLine());

                /*If the Grid Contains a bomb at the chosen cell (row, column) then display a message
                 * and set the endgame condition to true.
                 */
                if (game.grid[Row, Column].liveNeighbors == 9) 
                {
                    Console.Out.WriteLine("You have hit a mine. GAME OVER");
                    endgame = true;
                }

                //If all non bomb cells revealed, set endgame to true and display sucess message
                int NonBombCells = 0;

                for (int j = 0; j < game.grid.GetLength(0); j++) 
                {
                    for (int k = 0; k < game.grid.GetLength(1); k++) 
                    {
                        if (game.grid[j, k].liveNeighbors != 9 && game.grid[j, k].visited == false) 
                        {
                            NonBombCells = NonBombCells + 1;
                        }
                    }
                }

                Console.Out.WriteLine("There are " + NonBombCells + " remaining");
                if (NonBombCells == 0) 
                {
                    Console.Out.WriteLine("Congats you have won the game");
                }

                    //Otherwise reprint the grid
                    PrintBoardDuringGame(game, Row, Column);
            }

        }

        public static void PrintBoardDuringGame(board game, int row, int column)
        {
            game.grid[row, column].visited = true;
            
            for (int i = 0; i < game.grid.GetLength(0); i++)
            {
                Console.Out.Write("   *   ");
                Console.Out.Write(i);
            }
            Console.Out.WriteLine();
            Console.Out.WriteLine();

            for (int j = 0; j < game.grid.GetLength(0); j++)
            {
                Console.Out.WriteLine("----------------------------------------------------------------------------------------------------");
                for (int k = 0; k < game.grid.GetLength(1); k++)
                {
                    Console.Out.Write("   |   ");
                    if (game.grid[j, k].visited == true)
                    {
                        Console.Out.Write(game.grid[j, k].liveNeighbors);
                    }
                    else
                    {
                        Console.Out.Write("?");
                    }
                }
                Console.Out.Write("     |             *");
                Console.Out.Write(j);
                Console.Out.WriteLine();

            }

        }

        public static void printBoard(board game)
        {
            for (int i = 0; i < game.grid.GetLength(0); i++)
            {
                Console.Out.Write("   *   ");
                Console.Out.Write(i);
            }
            Console.Out.WriteLine();
            Console.Out.WriteLine();

            for (int j = 0; j < game.grid.GetLength(0); j++)
            {
                Console.Out.WriteLine("----------------------------------------------------------------------------------------------------");
                for (int k = 0; k < game.grid.GetLength(1); k++)
                {
                    Console.Out.Write("   |   ");
                    Console.Out.Write(game.grid[j, k].liveNeighbors);
                }
                Console.Out.Write("     |             *");
                Console.Out.Write(j);
                Console.Out.WriteLine();
                
            }
        }

        

       
    }
}
