//Problem 10:A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
//Use descriptive names. Print the data at the console.

using System;

namespace _10_EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Hristo";
            string lastName = "Hristov!";
            byte age = 25;
            string gender = "Male";
            long persIDNumber = 8306112507;
            long employeeNum = 27560000;
            Console.WriteLine("Your name is: {0}",firstName+" "+lastName );
            Console.WriteLine("Your age is: {0}",age) ;
            Console.WriteLine("Your are: {0}",gender );
            Console.WriteLine("Your pers. ID number is: {0}",persIDNumber );
            Console.WriteLine("Your employee Numer is: {0}",employeeNum );
 
        }
    }
}
