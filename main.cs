// Created by: Allen Li
// Created on: Oct 2022
//
// This program displays, "Hello, World!"

using System;

class Program
{
    public static void Main(string[] args)
    {
        // user input.
        int userAge;

        Console.WriteLine("What movie can you watch in your age?");
        Console.WriteLine("");
        Console.Write("Enter your age to test it: ");
        Console.WriteLine("");
        userAge = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine(" ");
        if (userAge >= 18)
        {
            Console.WriteLine("You can see G, PG and R rated movies!");
        }
        else if (userAge >= 13, userAge < 18)
        {
            Console.WriteLine("You can see G and PG rated movies!");
        }
        else if (userAge <= 12)
        {
            Console.WriteLine("You can see G rated movies!");
        }
        else
        {
            Console.WriteLine("you can hardly watch any movies");
        }

        Console.WriteLine("\nDone.");
    }
}