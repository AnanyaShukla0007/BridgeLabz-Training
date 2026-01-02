using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning
{
    internal class FestivalLuckyDraw
    {
        static void Main()
        {
            Console.Write("Enter number of visitors: ");
            int visitors = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= visitors; i++)
            {
                Console.Write("Visitor " + i + ", enter your number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number <= 0)
                {
                    Console.WriteLine("Invalid number. Try next visitor.");
                    continue;
                }

                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Congratulations! You won a gift !!");
                }
                else
                {
                    Console.WriteLine("Sorry, better luck next time.");
                }
            }
        }
    }
}
