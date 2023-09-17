using System;
using System.Collections.Generic;

namespace Lecture_1.Part_1.ZamazonDelivery
{
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
                //todo: try-catch block will be added and assign a default value in catch 
                //user can send a text which can not convert int

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
                        //todo: default block will be added to switch-case, write down a error message for user
                }
            }
        }

        static void AddCustomer()
        {
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();

            //todo: Control for customer name is null or white space
            //user may enter space string like: "   " we musn't accept it!

            //todo: Control for is there any same name in list which is added before

            customers.Add(customerName);
            Console.WriteLine($"Customer '{customerName}' added successfully!");
        }

        static void PlaceOrder()
        {
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();

            //todo: Control for is username exist

            Console.Write("Enter order details: ");
            string orderDetails = Console.ReadLine();
            //todo: Control for order details is null or white space
            //user may enter space string like: "   " we musn't accept it!

            orders.Add($"{customerName}: {orderDetails}");
            Console.WriteLine("Order placed successfully!");

        }

        static void ViewOrders()
        {
            //todo: Control for are there any order in (list) orders if there are nothing to show just write down "No Order Exist"
            Console.WriteLine("Orders:");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}
