using System;
using System.Collections.Generic;

class SnakeAndLadder
{
    static Random random = new Random();

    static Dictionary<int, int> snakesAndLadders = new()
    {
        { 4, 14 },   // Ladder
        { 9, 31 },
        { 17, 7 },   // Snake
        { 20, 38 },
        { 28, 84 },
        { 40, 59 },
        { 51, 67 },
        { 54, 34 },  // Snake
        { 62, 19 },
        { 64, 60 },
        { 71, 91 },
        { 87, 24 },
        { 93, 73 },
        { 95, 75 },
        { 99, 78 }
    };

    static void Main()
    {
        Console.Write("Enter number of players (2-4): ");
        int playerCount = int.Parse(Console.ReadLine());

        if (playerCount < 2 || playerCount > 4)
        {
            Console.WriteLine("Invalid number of players.");
            return;
        }

        List<string> players = new();
        Dictionary<string, int> positions = new();

        for (int i = 0; i < playerCount; i++)
        {
            Console.Write($"Enter Player {i + 1} name: ");
            string name = Console.ReadLine();
            players.Add(name);
            positions[name] = 0;
        }

        bool gameWon = false;

        while (!gameWon)
        {
            foreach (string player in players)
            {
                Console.WriteLine($"\n{player}'s turn. Press Enter to roll dice.");
                Console.ReadLine();

                int dice = RollDice();
                int oldPos = positions[player];
                int newPos = oldPos + dice;

                if (newPos > 100)
                {
                    Console.WriteLine($"{player} rolled {dice}. Move skipped (beyond 100).");
                    continue;
                }

                newPos = ApplySnakeOrLadder(newPos, out string message);
                positions[player] = newPos;

                Console.WriteLine($"{player} rolled {dice}: {oldPos} → {newPos}");
                if (message != "") Console.WriteLine(message);

                if (CheckWin(newPos))
                {
                    Console.WriteLine($"\n🎉 {player} WINS THE GAME! 🎉");
                    gameWon = true;
                    break;
                }
            }
        }
    }

    static int RollDice() => random.Next(1, 7);

    static int ApplySnakeOrLadder(int position, out string message)
    {
        message = "";
        if (snakesAndLadders.ContainsKey(position))
        {
            int newPos = snakesAndLadders[position];
            message = (newPos > position)
                ? $"🪜 Ladder! Climb up to {newPos}"
                : $"🐍 Snake! Slide down to {newPos}";
            return newPos;
        }
        return position;
    }

    static bool CheckWin(int position)
    {
        switch (position)
        {
            case 100: return true;
            default: return false;
        }
    }
}
