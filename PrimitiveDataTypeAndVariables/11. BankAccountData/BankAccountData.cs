/* A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names. */

using System;

    class BankAccountData
    {
        static void Main(string[] args)
        {
            string holderName = "Ivan Petkov Ivanov";
            long balance = 1548796;
            string bankName = "First Investment Bank";
            string iban = "BG80BNBG96611020345678";
            long firstCreditCardNumber = 1020102010201020;
            long secondCreditCardNumber = 2030203020302030;
            long thirdCreditCardNumber = 1030103010301030;
            Console.WriteLine("Information for a single bank account:\n");
            Console.WriteLine("A holder name: {0}\nAmount of money: {1}\nBank name: {2}\nIBAN: {3}", holderName, balance, bankName, iban);
            Console.WriteLine("Three credit card numbers:\nFirst number: {0}\nSecond number: {1}\nThird number: {2}", firstCreditCardNumber, secondCreditCardNumber, thirdCreditCardNumber);
            Console.Read();
        }
    }

