//Jeremy Sanders
//INSY 4306

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSproject2
{
    class GameMain
    {
        static void Main(string[] args)
        {
            
            int wins;
            int games;
            double winPct;
            bool cont;
            bool won;
            Game g;

            games = 0;
            wins = 0;
            cont = true;

            Console.WriteLine("Number Baseball Game by Jeremy Sanders");

            while (cont == true)
            {
                g = new Game();

                won = false;

                g.generateNumbers();
                g.displayCPUNumbers();
                won=g.runTurn();

                if (won == true)
                    wins = win(wins);
                else
                    loss();

                games++;

                winPct =(double) wins / games;
                Console.WriteLine(winPct);
                Console.WriteLine("{0} wins out of {1} games. Win percentage: {2:0%}.",wins,games,winPct);

                cont = checkContinue();

                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }
        }

        static int win(int w)
        {
            Console.WriteLine("You win!");
            w++;
            return w;
        }

        static void loss()
        {
            Console.WriteLine("You lose.");
        }

        static bool checkContinue()
        {
            string input;

            while (true)
            {
                Console.Write("Continue? (y/n) ");
                input = Console.ReadLine();

                if (input == "y")
                    return true;

                else if (input == "n")
                    return false;

                else
                    Console.WriteLine("Please enter y or n.");
            }

            Console.WriteLine("Error: checkContinue()");
            return false;
        }
    }
}
