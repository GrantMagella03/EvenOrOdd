using System;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        bool quit=false;
        while(!quit)
        {
            Console.Write($"Enter an integer: ");
            int input = 0 + Convert.ToInt32(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine($"{input} is even");
            }
            else
            {
                Console.WriteLine($"{input} is odd");
            }
            Console.Write($"Quit?(y/n): ");
            String input2 = ""+Console.ReadLine();
            if (input2 == "Y"||input2=="y")
            {
                quit=true;
            }
        }
    }
}