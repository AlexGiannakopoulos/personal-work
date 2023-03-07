using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe2
{
    internal class Game
    {
        public char[,] Board { get; set; }

        public Game() 
        { 
            init();
        }

        public void init()
        {
            Board= new char[,] {
                {'-', '-', '-' },
                {'-', '-', '-' },
                {'-', '-', '-' }
            };
        }

        public void display()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(Board[r, c] + " ");
                }
                Console.WriteLine();
            }
        }

      
        public bool play(Player p, int row, int col)
        {
            if(row < 1 || row > 3 || col < 1 || col > 3
            || Board[row - 1, col - 1] != '-')
            {
                return false;
            }
            else
            {
                Board[row - 1, col - 1] = p.Symbol;
                return true;
            }
        }

        public char getWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                // Check each row
                if (Board[i, 0] == Board[i, 1] &&
                    Board[i, 0] == Board[i, 2] &&
                    Board[i, 0] != '-')
                {
                    return Board[i, 0];
                }
                // Check each column
                else if (Board[0, i] == Board[1, i] &&
                    Board[0, i] == Board[2, i] &&
                    Board[0, i] != '-')
                {
                    return Board[0, i];
                }
            }
            // Check diagonals
            if (Board[0, 0] == Board[1, 1] &&
                Board[0, 0] == Board[2, 2] &&
                Board[0, 0] != '-')
            {
                return Board[0, 0];
            }
            if (Board[2, 0] == Board[1, 1] &&
                Board[2, 0] == Board[0, 2] &&
                Board[2, 0] != '-')
            {
                return Board[2, 0];
            }
            return '-';
        }

        public bool isTie()
        {
            bool isTie = true;
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (Board[r, c] == '-')
                    {
                        isTie = false;
                    }
                }
            }
            return isTie;
        }
    }
}
