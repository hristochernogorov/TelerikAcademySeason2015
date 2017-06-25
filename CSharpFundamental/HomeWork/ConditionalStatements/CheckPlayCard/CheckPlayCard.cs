//Problem 3:Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.

using System;

class CheckPlayCard
{
    static void Main()
    {
        Console.WriteLine("This program prints the result of your input.\nStandard card games have cards 2,3,4,5,6,7,8,9,10,J,Q,K and A.");
        Console.WriteLine("Please enter a value card to see if it is valid.");
        string inputCard = Console.ReadLine();
        string[] arr = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        bool isEqual = false;
  
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == inputCard) isEqual = true;
        }

        Console.WriteLine(isEqual ? "yes" : "no");
    }

}
    

