using System;

class CafeteriaService
{
    private Menu mainmenu= new Menu();

    public void Start()
    {
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("===== CAFETERIA MENU ====="); //main menu
            Console.WriteLine("1. Select Item"); //item selection
            Console.WriteLine("2. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                SelectItem();
            else if (choice == 2)
                Console.WriteLine("Thank you!");
            else
                Console.WriteLine("Invalid choice!");

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();

        } while (choice != 2);
    }

    private void SelectItem()
    {
        DisplayMenu();

        Console.Write("\nEnter item index: ");
        int index = int.Parse(Console.ReadLine());

        string item = menu.GetItemByIndex(index);

        if (item == null)
            Console.WriteLine("Invalid selection!");
        else
            Console.WriteLine("You selected: " + item);
    }

    private void DisplayMenu()
    {
        string[] items = menu.GetItems();

        for (int i = 0; i < items.Length; i++)
            Console.WriteLine(i + " -> " + items[i]);
    }
}
