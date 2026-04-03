using System;

// Meal plan interface
interface IMealPlan
{
    void ShowPlan();
}

class VegetarianMeal : IMealPlan
{
    public void ShowPlan()
    {
        Console.WriteLine("Vegetarian Meal Plan Generated");
    }
}

class VeganMeal : IMealPlan
{
    public void ShowPlan()
    {
        Console.WriteLine("Vegan Meal Plan Generated");
    }
}

// Generic meal class
class Meal<T> where T : IMealPlan, new()
{
    public void GenerateMeal()
    {
        T meal = new T();
        meal.ShowPlan();
    }
}

class Program
{
    static void Main()
    {
        Meal<VeganMeal> meal = new Meal<VeganMeal>();
        meal.GenerateMeal();
    }
}
