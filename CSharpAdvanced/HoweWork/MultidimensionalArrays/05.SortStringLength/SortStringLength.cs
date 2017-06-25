//Problem 5:You are given an array of strings. Write a method that
//sorts the array by the length of its elements (the number of characters composing them).

using System;

    class SortStringLength
    
    {
        static void Main()
        {
            Console.Write("Enter length of the array N=");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        //string[] array = new string[]{"a[[[","g","pe","r3","dd","g111","ddddc","gddw","tfdgd","dfo"};
        for (int i = 0; i < n; i++)
        {
            Console.Write("element[{0}]= ", i);
            array[i] = Console.ReadLine();
        }
        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        foreach (string element in array)
        {
            Console.WriteLine(element);
        }
        Console.WriteLine();
        }
    }

