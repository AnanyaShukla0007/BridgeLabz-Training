using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.ATMDispenser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = 880;

            // Scenario A: All notes available
            Console.WriteLine("Scenario A: All Notes Available");
            int[] notesA = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            ATM atmA = new ATM(notesA);
            DispenserLogic.DispenseCash(atmA, amount);

            Console.WriteLine();

            // Scenario B: ₹500 removed
            Console.WriteLine("Scenario B: ₹500 Removed");
            int[] notesB = { 200, 100, 50, 20, 10, 5, 2, 1 };
            ATM atmB = new ATM(notesB);
            DispenserLogic.DispenseCash(atmB, amount);

            Console.WriteLine();

            // Scenario C: Exact change not possible
            Console.WriteLine("Scenario C: No Exact Change");
            int[] notesC = { 100, 50 };
            ATM atmC = new ATM(notesC);
            DispenserLogic.DispenseCash(atmC, 30);

            Console.ReadLine();
        }
    }
}
