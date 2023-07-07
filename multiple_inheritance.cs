using System;

interface ICustomer
{
    string CustomerName { get; set; }
    int Age { get; set; }
}

class Bank
{
    public string BankName { get; set; }
    public string Branch { get; set; }

    public Bank(string bankName, string branch)
    {
        BankName = bankName;
        Branch = branch;
    }

    public void DisplayBankInfo()
    {
        Console.WriteLine("Bank Name: " + BankName);
        Console.WriteLine("Branch: " + Branch);
    }
}

class Account : ICustomer
{
    public int AccountNumber { get; set; }
    public decimal Balance { get; set; }
    public string CustomerName { get; set; }
    public int Age { get; set; }

    public Account(int accountNumber, decimal balance, string customerName, int age)
    {
        AccountNumber = accountNumber;
        Balance = balance;
        CustomerName = customerName;
        Age = age;
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Balance: " + Balance);
        Console.WriteLine("Customer Name: " + CustomerName);
        Console.WriteLine("Age: " + Age);
    }
}

class Program
{
    static void Main()
    {
        string bankName = "XYZ Bank";
        string branch = "Main Branch";

        Bank bank = new Bank(bankName, branch);
        bank.DisplayBankInfo();

        int accountNumber = 123456;
        decimal balance = 1000;
        string customerName = "John Doe";
        int age = 30;

        Account account = new Account(accountNumber, balance, customerName, age);
        account.DisplayAccountInfo();
    }
}
