using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {

            const int noPlayOption = 0;
            const int ladderOption = 1;
            const int snakeOption = 2;
            const int playerOne = 1;
            
            int positionOne = 0;
            int diceRollCount = 0;
            
            while (positionOne < 100)
            {
                Random random = new Random();
                int dieRoll = random.Next(1, 7);
                diceRollCount++;
                int options = random.Next(0, 3);
                Console.WriteLine("Position: " + positionOne);
                switch (options)
                {
                    case noPlayOption:
                        Console.WriteLine("Position: " + positionOne);
                        break;
                    case ladderOption:
                        if (positionOne + dieRoll <= 100)
                        {
                            positionOne = positionOne + dieRoll;
                        }
                        Console.WriteLine("Position: " + positionOne);
                        break;
                    case snakeOption:
                        positionOne = positionOne - dieRoll;
                        if (positionOne < 0)
                        {
                            positionOne = 0;
                        }
                        Console.WriteLine("Position: " + positionOne);
                        break;
                }
            }
            Console.WriteLine("Player Wins with Die Roll :" + diceRollCount);
        }
    }
}