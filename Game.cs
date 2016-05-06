//Jeremy Sanders
//INSY 4306

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSproject2
{
    class Game
    {
        private int[] cpu;
        private int[] player;
        private int strikes;
        private int balls;
        private int turns;

        public Game()
        {
            cpu = new int[3];
            player = new int[3];
        }

        public void displayCPUNumbers()
        {
            Console.Write("CPU Numbers: ");
            Console.Write(cpu[0]);
            Console.Write(cpu[1]);
            Console.WriteLine(cpu[2]);
        }

        public void generateNumbers()
        {
            Random rnd = new Random();

            cpu[0] = rnd.Next(1, 10);

            do
            {
                cpu[1] = rnd.Next(1, 10);
            }
            while (cpu[1] == cpu[0]);

            do
            {
                cpu[2] = rnd.Next(1, 10);
            }
            while (cpu[2] == cpu[0] || cpu[2] == cpu[1]);
        }

        public void playerNumbers()
        {
            Console.WriteLine("Enter three numbers, pressing enter after each number:");
            player[0] = Int32.Parse(Console.ReadLine());
            player[1] = Int32.Parse(Console.ReadLine());
            player[2] = Int32.Parse(Console.ReadLine());
        }

        public bool runTurn()
        {
            for (turns = 1; turns < 6; turns++)
            {
                strikes = 0;
                balls = 0;
                Console.WriteLine("Turn " + turns);
                playerNumbers();

                Console.Write(player[0]);
                Console.Write(player[1]);
                Console.WriteLine(player[2]);

                if (player[0] == cpu[0])
                    strikes++;

                if (player[1] == cpu[1])
                    strikes++;

                if (player[2] == cpu[2])
                    strikes++;

                if (player[0] == cpu[1] || player[0] == cpu[2])
                    balls++;

                if (player[1] == cpu[0] || player[1] == cpu[2])
                    balls++;

                if (player[2] == cpu[0] || player[2] == cpu[1])
                    balls++;

                Console.WriteLine(strikes + " strikes and " + balls + " balls.");

                if (strikes >= 3)
                    return true;
            }

            return false;
        }
    }
}
