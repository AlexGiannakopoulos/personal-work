using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe2
{
    internal class Player
    {
        public char Symbol { get; set; }
        public int Score { get; set; }  

        public Player(char Symbol) 
        { 
            this.Symbol = Symbol;
            this.Score = 0;
        }

        public int[] GetPosition()
        {
            Console.WriteLine(Symbol + " play");
            Console.Write("Row: ");
            int row = Int32.Parse(Console.ReadLine());
            Console.Write("Col: ");
            int col = Int32.Parse(Console.ReadLine());
            int[] values = { row, col };
            return values;
        }
    }
}
