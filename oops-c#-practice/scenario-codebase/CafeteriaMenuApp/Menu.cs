using System;

class Menu
{
    private string[] items =
    {
        "Burger", "Pizza", "Pasta", "Sandwich", "Fries",
        "Coffee", "Tea", "Juice", "Momos", "Noodles"
    };

    public string[] GetItems()
    {
        return items;
    }

    public string GetItemByIndex(int index)
    {
        if (index >= 0 && index < items.Length)
            return items[index];

        return null;
    }
}
