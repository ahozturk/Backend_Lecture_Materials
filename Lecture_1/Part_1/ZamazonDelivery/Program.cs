using System;
using System.Collections.Generic;

namespace Lecture_1.Part_1.InsecureBank;
class Program
{
    static List<string> customers = new List<string>();
    static List<string> orders = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Zamazon Customer and Order Management System");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Place Order");
            Console.WriteLine("3. View Orders");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddCustomer();
                    break;
                case 2:
                    PlaceOrder();
                    break;
                case 3:
                    ViewOrders();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    return;
            }
        }
    }

    static void AddCustomer()
    {
        Console.Write("Enter customer name: ");
        string customerName = Console.ReadLine();
        customers.Add(customerName);
        Console.WriteLine($"Customer '{customerName}' added successfully!");
    }

    static void PlaceOrder()
    {
        Console.Write("Enter customer name: ");
        string customerName = Console.ReadLine();

        Console.Write("Enter order details: ");
        string orderDetails = Console.ReadLine();
        orders.Add($"{customerName}: {orderDetails}");
        Console.WriteLine("Order placed successfully!");

    }

    static void ViewOrders()
    {
        Console.WriteLine("Orders:");
        foreach (var order in orders)
        {
            Console.WriteLine(order);
        }
    }
}
