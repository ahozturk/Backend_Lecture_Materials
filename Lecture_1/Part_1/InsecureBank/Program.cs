using System;
using System.Collections.Generic;

namespace Lecture_1.Part_1.InsecureBank;
class Program
{
    static List<string> accountOwners = new List<string>();
    static List<double> accountBalances = new List<double>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Welcome to the Insecure Bank!");
            Console.WriteLine("1. Create an Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateAccount();
                    break;
                case 2:
                    DepositMoney();
                    break;
                case 3:
                    WithdrawMoney();
                    break;
                case 4:
                    CheckBalance();
                    break;
                case 5:
                    Console.WriteLine("Thank you for using the Insecure Bank!");
                    return;
            }
        }
    }

    static void CreateAccount()
    {
        Console.Write("Enter your name: ");
        string ownerName = Console.ReadLine();

        accountOwners.Add(ownerName);
        accountBalances.Add(0.0);

        Console.WriteLine("Account created successfully!");
    }

    static void DepositMoney()
    {
        Console.Write("Enter your name: ");
        string ownerName = Console.ReadLine();
        int index = accountOwners.IndexOf(ownerName);

        Console.Write("Enter the amount to deposit: ");
        double amount = double.Parse(Console.ReadLine());
        accountBalances[index] += amount;
        Console.WriteLine($"Deposited ${amount}. New balance: ${accountBalances[index]}");

    }

    static void WithdrawMoney()
    {
        Console.Write("Enter your name: ");
        string ownerName = Console.ReadLine();
        int index = accountOwners.IndexOf(ownerName);

        Console.Write("Enter the amount to withdraw: ");
        double amount = double.Parse(Console.ReadLine());

        if (accountBalances[index] >= amount)
        {
            accountBalances[index] -= amount;
            Console.WriteLine($"Withdrawn ${amount}. New balance: ${accountBalances[index]}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    static void CheckBalance()
    {
        Console.Write("Enter your name: ");
        string ownerName = Console.ReadLine();
        int index = accountOwners.IndexOf(ownerName);

        Console.WriteLine($"Your balance is ${accountBalances[index]}");
    }
}
