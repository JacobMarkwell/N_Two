using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of N:");
        int N = int.Parse(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("N must be a positive integer.");
            return;
        }

        // Loop through rows
        for (int i = 1; i <= N; i++)
        {
            // Loop through columns
            for (int j = 1; j <= N; j++)
            {
                // Print the current number
                Console.Write("{0,3}", i);
            }
            // Move to the next row
            Console.WriteLine();
        }
    }
}