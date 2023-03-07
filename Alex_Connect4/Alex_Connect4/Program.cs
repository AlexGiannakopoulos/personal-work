
using Alex_Connect4;


Player r = new Player('R');
Player y = new Player('Y');
Player current = r;

Game game = new Game();

do
{
    game.Display();
    int pos = current.GetPosition();
    if (game.Play(current, pos))
    {
        char winner = game.GetWinner();
        if (winner != '_')
        {
            game.Display();
            Console.WriteLine(winner + " Wins!");
            break;
        }

        if (game.IsTie())
        {
            game.Display();
            Console.WriteLine("Tie!");
            break;
        }

        current = current == r ? y : r;
    }
    else
    {
        Console.WriteLine("Error...");
    }

} while (true);