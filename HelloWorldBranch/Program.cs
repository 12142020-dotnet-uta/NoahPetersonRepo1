﻿using System;

namespace HelloWorldBranch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter a word.");
            string response = Console.ReadLine();
            Console.WriteLine($"Your response is {response}.");
        }
    }
}
