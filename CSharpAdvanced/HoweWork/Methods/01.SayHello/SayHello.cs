﻿//Problem 1:Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method


using System;

class SayHello
{
    static void PrintName()
    {
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        PrintName();

    }
}

