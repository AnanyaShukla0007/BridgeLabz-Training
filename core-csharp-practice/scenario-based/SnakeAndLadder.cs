using System;
class SnakeAndLadder
{
    static Random random = new Random();
    static void Main()
    {
        int choice;
        do
        {
            Console.Clear();
            Console.WriteLine("===== SNAKE AND LADDER =====");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. View Rules");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    StartGame();
                    break;

                case 2:
                    ShowRules();
                    break;

                case 3:
                    Console.WriteLine("Exiting game.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            if (choice != 3)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        } while (choice != 3);
    }
    static void StartGame()
    {
        Console.Clear();
        Console.Write("Enter number of players (2-4): ");
        int playerCount = int.Parse(Console.ReadLine());

        if (playerCount < 2 || playerCount > 4)
        {
            Console.WriteLine("Invalid number of players.");
            return;
        }
        string[] players = new string[playerCount];
        int[] positions = new int[playerCount];
       for (int i = 0; i < playerCount; i++)
        {
            Console.Write($"Enter Player {i + 1} name: ");
            players[i] = Console.ReadLine();
            positions[i] = 0;
        }
        bool gameWon = false;
        while (!gameWon)
        {
            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine($"\n{players[i]}'s turn. Press Enter to roll dice.");
                Console.ReadLine();
                int dice = RollDice();
                int oldPos = positions[i];
                int newPos = MovePlayer(oldPos, dice);
                if (newPos == oldPos)
                {
                    Console.WriteLine($"{players[i]} rolled {dice}. Move skipped.");
                    continue;
                }
                string message;
                newPos = ApplySnakeOrLadder(newPos, out message);
                positions[i] = newPos;
                Console.WriteLine($"{players[i]} rolled {dice}: {oldPos} -> {newPos}");
                if (message != "")
                    Console.WriteLine(message);

                if (CheckWin(newPos))
                {
                    Console.WriteLine($"\n{players[i]} WINS THE GAME!");
                    gameWon = true;
                    break;
                }
            }
        }
    }
    static void ShowRules()
    {
        Console.Clear();
        Console.WriteLine("===== GAME RULES =====");
        Console.WriteLine("1. Board has 100 cells (1 to 100).");
        Console.WriteLine("2. All players start at position 0.");
        Console.WriteLine("3. Dice generates numbers from 1 to 6.");
        Console.WriteLine("4. Player must reach exactly 100 to win.");
        Console.WriteLine("5. If move exceeds 100, turn is skipped.");
        Console.WriteLine("6. Landing on ladder moves player up.");
        Console.WriteLine("7. Landing on snake moves player down.");
    }
    static int RollDice()
    {
        return random.Next(1, 7);
    }
    static int MovePlayer(int currentPosition, int dice)
    {
        int nextPosition = currentPosition + dice;
        if (nextPosition > 100)
            return currentPosition;

        return nextPosition;
    }
    static int ApplySnakeOrLadder(int position, out string message)
    {
        message = "";
        switch (position)
        {
            case 4:  message = "Ladder from 4 to 14"; return 14;
            case 9:  message = "Ladder from 9 to 31"; return 31;
            case 17: message = "Snake from 17 to 7"; return 7;
            case 20: message = "Ladder from 20 to 38"; return 38;
            case 28: message = "Ladder from 28 to 84"; return 84;
            case 40: message = "Ladder from 40 to 59"; return 59;
            case 51: message = "Ladder from 51 to 67"; return 67;
            case 54: message = "Snake from 54 to 34"; return 34;
            case 62: message = "Snake from 62 to 19"; return 19;
            case 64: message = "Snake from 64 to 60"; return 60;
            case 71: message = "Ladder from 71 to 91"; return 91;
            case 87: message = "Snake from 87 to 24"; return 24;
            case 93: message = "Snake from 93 to 73"; return 73;
            case 95: message = "Snake from 95 to 75"; return 75;
            case 99: message = "Snake from 99 to 78"; return 78;
            default: return position;
        }
    }
    static bool CheckWin(int position)
    {
        return position == 100;
    }
}