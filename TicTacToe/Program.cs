using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            bool player1Turn = true;
            int numTurns = 0;

            while (!checkVictory() && numTurns !=9)
            {
                PrintGrid();

                if (player1Turn)
                {
                    Console.WriteLine("Player 1 turn");
                }
                else
                {
                    Console.WriteLine("Player 2 turn");
                }
                string choise = Console.ReadLine();

                if (grid.Contains(choise) && choise != "X" && choise != "O")
                {
                    int gridIndex = Convert.ToInt32(choise) - 1;

                    if (player1Turn)
                        grid[gridIndex] = "X";
                    else grid[gridIndex] = "O";
                    numTurns++;
                }
                player1Turn = !player1Turn;
            }
            if (checkVictory())
                Console.WriteLine("Player 1 win,Hurrahhhh!!!!");
            else
                Console.WriteLine("Player 2 win,Hurrahhhh!!!!");
            bool checkVictory()
            {
                bool row1 = grid[0] == grid[1] && grid[1] == grid[2];
                bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
                bool row3 = grid[6] == grid[7] && grid[7] == grid[8];
                bool row4 = grid[0] == grid[3] && grid[3] == grid[6];
                bool row5 = grid[1] == grid[4] && grid[4] == grid[7];
                bool row6 = grid[2] == grid[5] && grid[5] == grid[8];
                bool diagup = grid[0] == grid[4] && grid[4] == grid[8];
                bool diagdown = grid[6] == grid[4] && grid[4] == grid[2];

                return row1 || row2 || row3 || row4 || row5 || row6 || diagup || diagdown;
            }

            void PrintGrid()
            { 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grid[i * 3 + j] + "|");
                }
                Console.WriteLine();
                Console.WriteLine("------");
            }
        }
                Console.ReadKey();

        }
    }
}
