﻿using System;

namespace Arrays_and_Lists___Exercise_5
{
    internal class Program
    {
        // 5- Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).
        // If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
        // otherwise, display the 3 smallest numbers in the list.

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers seperated by commas");
            string userInputString = Console.ReadLine();
            string userInputStringSeperated = userInputString.Split(',')[0];

            Console.WriteLine(userInputStringSeperated);
        }
    }
}
