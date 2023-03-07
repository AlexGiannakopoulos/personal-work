

namespace Alex_Connect4
{
    public class Game
    {
        public char[,] Board{ get; set; }

        public Game()
        {
            Init();
        }
        
        public void Init()
        {
            Board = new char[,] {
                { '_', '_', '_', '_', '_', '_', '_' },
                { '_', '_', '_', '_', '_', '_', '_' },
                { '_', '_', '_', '_', '_', '_', '_' },
                { '_', '_', '_', '_', '_', '_', '_' },
                { '_', '_', '_', '_', '_', '_', '_' },
                { '_', '_', '_', '_', '_', '_', '_' },
            };
        }

        public void Display()
        {
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7;c++)
                {
                    Console.Write(Board[r, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public bool Play(Player p, int col)
        {
            if (col < 1 || col > 7 || Board[0, col - 1] != '_')
            {
                return false;
            }
            else 
            {
                for (int i = 5; i > -1; i--)
                {
                    if (Board[i, col-1] == '_')
                    {
                        Board[i, col-1] = p.Color;
                        return true;
                    }
                }
            }

            return false;
        }

        public char GetWinner()
        {
            //check row
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Board[i, j] == Board[i, j + 1] &&
                        Board[i, j] == Board[i, j + 2] &&
                        Board[i, j] == Board[i, j + 3] &&
                        Board[i, j] != '_')
                    {
                        return Board[i, j];
                    }
                    //check col
                    else if (Board[i, j] == Board[i + 1, j] &&
                             Board[i, j] == Board[i + 2, j] &&
                             Board[i, j] == Board[i + 3, j] &&
                             Board[i, j] != '_')
                    {
                        return Board[i, j];
                    }
                }
            }
            //check diagonals
                //check right side diagonals
            for (int i = 0; i < 3; i++) // only first 3 rows can have diagonal winner
            {
                for (int j = 0; j < 4; j++) // only first 4 cols can have -//- winner
                {
                    if (Board[i, j] == Board[i + 1, j + 1] &&
                        Board[i, j] == Board[i + 2, j + 2] &&
                        Board[i, j] == Board[i + 3, j + 3] &&
                        Board[i, j] != '_') // this checks diagonals for each row
                    {
                        return Board[i, j];
                    }
                }
            }
                //check left side diagonals
                for (int i = 0; i < 3; i++) //starts 1st row last col
                {
                    for (int j = 6; j > 2; j--)
                    {
                        if (Board[i, j] == Board[i + 1, j - 1] &&
                            Board[i, j] == Board[i + 2, j - 2] &&
                            Board[i, j] == Board[i + 3, j - 3] &&
                            Board[i, j] != '_')
                        {
                            return Board[i, j];
                        }
                    }
                }

                return '_';
        }

        public bool IsTie()
        {
            bool isTie = true;
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (Board[r, c] == '_')
                    {
                        isTie = false;
                    }
                }
            }
            return isTie;
        }
    }
}