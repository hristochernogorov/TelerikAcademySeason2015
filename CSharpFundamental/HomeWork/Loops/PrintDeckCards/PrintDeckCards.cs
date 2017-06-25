// Problem 4:Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.



namespace PrintDeckCards
{
    using System;
    class PrintDeckCards
    {
        static void Main()
        {

            string[] facesCards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] colorsCards = { " of CLUBS", " of DIAMONDS", " of HEARTS", " of SPADES" };

            Console.WriteLine("Standart deck of 52 play cards contain:");
            Console.WriteLine();
            foreach (var face in facesCards)
            {
                foreach (var color in colorsCards)
                {
                    Console.Write("{0,3}{1} ", face, color);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
