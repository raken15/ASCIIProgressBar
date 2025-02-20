using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string to display in the progress bar: ");
        string inputString = Console.ReadLine() ?? ""; // Get user input
        int total = inputString.Length; // Progress bar length matches string length

        Console.WriteLine("\nLoading...");

        for (int i = 0; i <= total; i++)
        {
            Console.Write("\r["); // Start of the progress bar
            Console.Write(inputString.Substring(0, i)); // Revealed part of the string
            Console.Write(new string('-', total - i)); // Unrevealed part as '-'
            Console.Write($"] {i * 100 / total}%"); // Percentage display

            Thread.Sleep(200); // Simulate loading delay
        }

        Console.WriteLine("\nDone!");
    }
}