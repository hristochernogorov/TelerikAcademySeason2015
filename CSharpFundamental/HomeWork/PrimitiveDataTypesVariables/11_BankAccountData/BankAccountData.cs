//Problem 11: A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

namespace _11_BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Hristo";
            string middleName = "Hristov";
            string lastName = "Hristov";
            object fullName = firstName + " " + middleName + " " + lastName;
            decimal moneyBalance = 8543.35M;
            string bankName = "UBB bank";
            string IBAN = "BG2345UBB1234567899876543";
            string visaElectron = "1234 5678 9098 7654";
            string masterCard = "9876 5432 1235 5647";
            string visaGold = "3425 8756 3482 6532";
            Console.WriteLine("Wellcome in {0} dear: \n{1}",bankName ,fullName );
            Console.WriteLine("Your IBAN is:{0}\n",IBAN );
            Console.WriteLine("In our bank you have 3 credit cards:\nVisaElectron №:{0}\nMasterCard №:{1}\nVisaGold №:{2}\n",visaElectron ,masterCard ,visaGold );
            Console.WriteLine("Your account balance is : {0} lv.",moneyBalance);

        }
    }
}
