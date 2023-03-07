namespace Alex_Connect4;

public class Player
{
    public char Color { get; set; }
    public int Score { get; set; }

    public Player(char color)
    {
        this.Color = color;
        this.Score = 0;
    }

    public int GetPosition()
    {
        Console.WriteLine(Color + " play");
        Console.Write("Col: ");
        int col = Int32.Parse((Console.ReadLine()));
        return col;
    }
}