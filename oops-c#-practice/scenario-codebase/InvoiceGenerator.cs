/*
QUESTION:
Invoice Generator for Freelancers

Scenario:
A freelancer receives invoice details in a single string.

Example Input:
"Logo Design - 3000 INR, Web Page - 4500 INR"

Requirements:
1. Split the string to extract task names and amounts.
2. Calculate the total invoice amount.
3. Use methods:
   - ParseInvoice(string input)
   - GetTotalAmount(string[] tasks)
4. Program should be menu driven.
*/
/*
using System;

class InvoiceGenerator
{
	static void Main()
	{
		int choice;

		do
		{
			Console.Clear();
			Console.WriteLine("===== INVOICE GENERATOR =====");
			Console.WriteLine("1. Generate Invoice");
			Console.WriteLine("2. Exit");
			Console.Write("Enter choice: ");

			choice = int.Parse(Console.ReadLine());

			if (choice == 1)
				GenerateInvoice();
			else if (choice == 2)
				Console.WriteLine("Exiting...");
			else
				Console.WriteLine("Invalid choice!");

			Console.WriteLine("\nPress Enter to continue...");
			Console.ReadLine();

		} while (choice != 2);
	}

	static void GenerateInvoice()
	{
		Console.WriteLine("\nEnter invoice details:");
		string input = Console.ReadLine();

		string[] tasks = ParseInvoice(input);
		int totalAmount = GetTotalAmount(tasks);

		Console.WriteLine("Total Invoice Amount: " + totalAmount + " INR");
	}

	static string[] ParseInvoice(string input)
	{
		return input.Split(", ");
	}

	static int GetTotalAmount(string[] tasks)
	{
		int sum = 0;

		foreach (string task in tasks)
		{
			// Extract only numeric amount
			string amountPart = task.Split('-')[1];
			int amount = int.Parse(amountPart.Split(' ')[1]);
			sum += amount;
		}

		return sum;
	}
}
