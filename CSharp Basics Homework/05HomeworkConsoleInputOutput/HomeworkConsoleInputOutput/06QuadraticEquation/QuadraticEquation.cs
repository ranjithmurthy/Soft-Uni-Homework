﻿using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input a,b and c each on a seperate line: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double x1 = (-b - (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);
        double x2 = (-b + (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);
        if(((b*b) - (4*a*c)) < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (x1 == x2)
        {
            Console.WriteLine("x1 = x2 = {0}",x1);
        }
        else
        {
            Console.WriteLine("x1 = {0}; x2 = {1};", x1, x2);
        }
    }
}

