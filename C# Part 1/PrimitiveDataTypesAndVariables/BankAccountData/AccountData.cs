//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class AccountData
{
    static void Main(string[] args)
    {
        string firstName = "Andrei";
        string middleName = "Asenov";
        string lastName = "Vasilev";
        object fullName = firstName + " " + middleName + " " + lastName;
        decimal balance = 1301.25m;
        string bankName = "Banka";
        string iban = "BG99BNB999222131313";
        ulong firstCreditCard = 111111222233334344u;
        ulong secondCreditCard = 2222111444556778899u;
        ulong thirdCreditCard = 5546255552225151512u;
        Console.WriteLine("Account holder: " + fullName);
        Console.WriteLine("Money balance: "+balance);
        Console.WriteLine("Bank name: "+bankName);
        Console.WriteLine("IBAN: "+iban);
        Console.WriteLine("The number of credit card(1): "+firstCreditCard
            +"\nThe number of credit card(2): "+secondCreditCard
            +"\nThe number of credit card(3): "+thirdCreditCard);
    }
}

