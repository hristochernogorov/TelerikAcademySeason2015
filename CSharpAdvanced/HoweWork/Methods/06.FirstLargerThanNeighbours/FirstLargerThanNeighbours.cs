//Problem 6:Write a method that returns the index of the first element in array that is
//larger than its neighbours,or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //This is another variant index of return value.For try to exchange this
        //{ 12, 25, 9, 8, 5, 4,};

        int[] array = new int[] { 12, 25, 9, 8, 5, 4, };

        //{ 12, 11, 9, 8, 5, 4 };

        for (int i = 1; i < array.Length; i++)
        {

            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                Console.WriteLine("{0}", array[i]);
                return;
            }
            else
            {
                int element = -1;
                Console.WriteLine(element);
                break;
            }
        }
    }
}

