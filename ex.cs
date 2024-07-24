using System;

class Program
{
    static void Main()
    {
        double sum = 1.0; // Initial value
        double Z = 5.0;   // Some constant or another variable

        for (int i = 0; i < 10; i++) // Iterative loop
        {
            sum = Z + 4 / sum;
            Console.WriteLine(sum);
        }
    }
}
