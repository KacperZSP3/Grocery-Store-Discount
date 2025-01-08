// Instructions:
// A grocery store gives a 10% discount for purchases above $100.
// The program should calculate the total price after the discount (if applicable).
// Example:
// Input: Total purchase = $120
// Output: Discounted price = $108

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter total purchase amount:");
        double total = Convert.ToDouble(Console.ReadLine());

        if (total > 100)
        {
            total -= total * 0.1;
        }

        Console.WriteLine("Total after discount: $" + total);
    }
}
