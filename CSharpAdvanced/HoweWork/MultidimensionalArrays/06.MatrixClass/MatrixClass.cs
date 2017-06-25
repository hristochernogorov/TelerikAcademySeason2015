//Problem 6:Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting
//and multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;
class MatrixClass
{
    static void Main()
    {
          //using 2D-ARRAYS
            int RowSize = 5, ColSize = 5;
            int[,] Matrix1 = new int[RowSize, ColSize];
            int[,] Matrix2 = new int[RowSize, ColSize];
            int[,] ResultMatrix = new int[RowSize, ColSize];
            int i, j;


            try
            {
                Console.WriteLine("\n >>> PROGRAM To PRINT ADDITION OF TWO MATRICES <<<");
                Console.Write("\n Enter the Size of a Matrix N*N (For Example:3*3) : ");
                string s = Console.ReadLine();
                string[] values = s.Split('*');
                RowSize = int.Parse(values[0]);
                ColSize = int.Parse(values[1]);

                if (RowSize > 5 || ColSize > 5)   //limiting the size of matrix
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed; //changing background color to red
                    Console.WriteLine(" The Size Of Matrix should Be in Less Than 5 (limiting size of array)");
                    System.Console.ResetColor(); ///resetting color
                    Console.WriteLine("\n\n\t Press Enter key to exit....");                             
                    Console.ReadKey(); return;
                }

                else
                {

                    //Initializing all the elements to zero
                    for (i = 0; i < RowSize; i++)
                    {
                        for (j = 0; j < ColSize; j++)
                        {
                            Matrix1[i, j] = 0;
                            Matrix2[i, j] = 0;
                        }
                    }
                    //Reading elements of Matrix1
                    Console.WriteLine("\n Enter the elements of Matrix1({0}*{1})", RowSize, ColSize);
                    for (i = 0; i < RowSize; i++)
                    {
                        for (j = 0; j < ColSize; j++)
                        {
                            Console.Write(" Matrix1[{0},{1}] : ", i, j);
                            Matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    //Reading elements of Matrix2
                    Console.WriteLine("\n Enter the elements of Matrix2({0}*{1})", RowSize, ColSize);
                    for (i = 0; i < RowSize; i++)
                    {
                        for (j = 0; j < ColSize; j++)
                        {
                            Console.Write(" Matrix2[{0},{1}] : ", i, j);
                            Matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    //calculating ResultMatrix, by adding Matrix1 and Matrix2
                    for (i = 0; i < RowSize; i++)
                    {
                        for (j = 0; j < ColSize; j++)
                        {
                            ResultMatrix[i, j] = Matrix1[i, j] + Matrix2[i, j];
                        }
                    }

                    //Printing Result Matrix
                    Console.Write("\n\n\t*** Result Matrix  ***\n\n\t");
                    for (i = 0; i < RowSize; i++)
                    {

                        for (j = 0; j < ColSize; j++)
                        {
                            if (ResultMatrix[i, j] < 10) 
                            {
                                Console.Write("  0" + Convert.ToString(ResultMatrix[i, j])); //Making number as 01,02,etc,. 
                            }
                            else
                            {
                                Console.Write("  " + Convert.ToString(ResultMatrix[i, j]));
                            }

                            if (j == ColSize - 1) { Console.Write("\n\t"); }

                        }
                    }
                }
            }
            catch  //to catch exceptions,suppose string entered as aRowSize or Colsize  of matrix
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("WARNING:only Number are allowed, Enter Correct Input");
                Console.ResetColor();
            }

            Console.WriteLine("\n\n\t Press Enter key to exit....");
            Console.ReadLine();
        }
}
     


    

