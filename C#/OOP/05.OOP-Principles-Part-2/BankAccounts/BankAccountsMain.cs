//Problem 2. Bank accounts

//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be 
//individuals or companies.
//All accounts have customer, balance and interest rate (monthly based).
//Deposit accounts are allowed to deposit and with draw money.
//Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: 
//number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces.
//You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest 
//functionality through overridden methods.

using System;

namespace BankAccounts
{
    class BankAccountsMain
    {
        static void Main(string[] args)
        {
            Customer stefan = new Individual("a001", "Stefan", "213209753", new DateTime(1990, 12 ,07), Gender.Male);
            Customer firma = new Company("a002", "tova", "901293841");

            Console.WriteLine(firma is Individual);
            Console.WriteLine(stefan is Individual);

            BankAccount mortgageAccTest = new MortgageAccount(200.2m, 0.6m, stefan);
            BankAccount mortgageAccTest1 = new MortgageAccount(200.2m, 0.6m, firma);

            Console.WriteLine(mortgageAccTest.CalculateInterest(15));
            Console.WriteLine(mortgageAccTest1.CalculateInterest(15));

            BankAccount loanAccTest = new LoanAccount(200.2m, 0.6m, stefan);
            BankAccount loanAccTest1 = new LoanAccount(200.2m, 0.6m, firma);

            Console.WriteLine(loanAccTest.CalculateInterest(11));
            Console.WriteLine(loanAccTest1.CalculateInterest(11));

            BankAccount depositAccTest = new DepositAccount(3200.2m, 0.6m, stefan);
            BankAccount depositAccTest1 = new DepositAccount(1200.2m, 0.6m, firma);

            Console.WriteLine(depositAccTest.CalculateInterest(11));
            Console.WriteLine(depositAccTest1.CalculateInterest(11));

            depositAccTest.Deposit(200);
            Console.WriteLine(depositAccTest.Balance);
            var depositAcc = depositAccTest as DepositAccount;
            depositAcc.Withdraw(300);
            Console.WriteLine(depositAcc.Balance);
        }
    }
}
