using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slotz
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.playGame();

            Console.ReadLine();
        }
    }
}