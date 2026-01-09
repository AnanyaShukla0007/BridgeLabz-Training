using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.ATMDispenser
{
    internal class DispenserLogic
    {
        public static void DispenseCash(ATM atm, int amount)
        {
            int remaining = amount;
            int[] notes = atm.Notes;
            int[] count = new int[notes.Length];

            // Greedy algorithm using array
            for (int i = 0; i < notes.Length; i++)
            {
                count[i] = remaining / notes[i];
                remaining = remaining % notes[i];
            }

            // Scenario C: fallback if exact change not possible
            if (remaining != 0)
            {
                Console.WriteLine("Exact change not possible.");
                return;
            }

            Console.WriteLine("Dispensed Notes:");
            for (int i = 0; i < notes.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine("₹" + notes[i] + " x " + count[i]);
                }
            }
        }
    }
}
