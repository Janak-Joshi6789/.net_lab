﻿using System;

class EvenOddChecker
{
    public void CheckEvenOdd()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is an Even number.");
        }
        else
        {
            Console.WriteLine(number + " is an Odd number.");
        }
    }
}
