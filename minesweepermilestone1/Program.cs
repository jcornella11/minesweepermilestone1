using System;

namespace minesweepermilestone1
{
    class Program
    {
        static void Main(string[] args)
        {
            board game = new board(10);
            printBoard(game);

            int engdgame = 1;

            while (engdgame != 0) 
            {
                //Ask the User for the Row and Column Number

                /*If the Grid Contains a bomb at the chosen cell (row, column) then display a message
                 * and set the endgame condition to true.
                 */

                //If all non bomb cells revealed, set endgame to true and display sucess message

                //Otherwise reprint the grid
               
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

        public static void PrintBoardDuringGame()
        {

        }

       
    }
}
