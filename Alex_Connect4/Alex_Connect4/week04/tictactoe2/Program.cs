
using tictactoe2;

Player x = new Player('X');
Player o = new Player('O');
Player current = x;
Game game = new Game();

do
{
    game.display();
    int[] pos = current.GetPosition();
    if (game.play(current, pos[0], pos[1]))
    {
        char winner = game.getWinner();
        if(winner != '-')
        {
            game.display();
            Console.WriteLine(winner + " wins!");
            break;
        }
        if(game.isTie())
        {
            game.display();
            Console.WriteLine("TIE");
            break;
        }
        current = current == x ? o : x;
    }
    else
    {
        Console.WriteLine("Error");
    }

} while (true);

/*

// Declare and intitalize variables
//char Player = 'X';
int scoreX = 0;
int scoreO = 0;

do
{
    char[,] Board = {
    {'-', '-', '-' },
    {'-', '-', '-' },
    {'-', '-', '-' }
};
    bool GameOver = false;

    // loop (until win or tie)
    do
    {
        // Display board
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write(Board[r, c] + " ");
            }
            Console.WriteLine();
        }
        // Ask current user row and column
        Console.WriteLine(Player + " play");
        Console.Write("Row: ");
        int row = Int32.Parse(Console.ReadLine());
        Console.Write("Col: ");
        int col = Int32.Parse(Console.ReadLine());
        // Check if valid
        // If not valid
        if (row < 1 || row > 3 || col < 1 || col > 3
            || Board[row - 1, col - 1] != '-')
        {
            // Error message
            Console.WriteLine("Wrong values");
        }
        else
        {
            // play
            Board[row - 1, col - 1] = Player;
            // Check win or tie 
            for (int i = 0; i < 3; i++)
            {
                // Check each row
                if (Board[i, 0] == Board[i, 1] &&
                    Board[i, 0] == Board[i, 2] &&
                    Board[i, 0] != '-')
                {
                    Console.WriteLine(Board[i, 0] + " wins");
                    GameOver = true;
                }
                // Check each column
                else if (Board[0, i] == Board[1, i] &&
                    Board[0, i] == Board[2, i] &&
                    Board[0, i] != '-')
                {
                    Console.WriteLine(Board[0, i] + " wins");
                    GameOver = true;
                }
            }
            // Check diagonals
            if (Board[0, 0] == Board[1, 1] &&
                Board[0, 0] == Board[2, 2] &&
                Board[0, 0] != '-')
            {
                Console.WriteLine(Board[0, 0] + " wins");
                GameOver = true;
            }
            if (Board[2, 0] == Board[1, 1] &&
                Board[2, 0] == Board[0, 2] &&
                Board[2, 0] != '-')
            {
                Console.WriteLine(Board[2, 0] + " wins");
                GameOver = true;
            }
            // Check tie 
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
            if (isTie)
            {
                Console.WriteLine("TIE");
                GameOver = true;
            }
            // Change player
            Player = Player == 'X' ? 'O' : 'X';
        }

    } while (!GameOver);

    // Display board
    for (int r = 0; r < 3; r++)
    {
        for (int c = 0; c < 3; c++)
        {
            Console.Write(Board[r, c] + " ");
        }
        Console.WriteLine();
    }

    Console.Write("Play again (y/n): ");
    string playAgain = Console.ReadLine();
    if (playAgain != "y")
    {
        break;
    }
} while (true);

*/