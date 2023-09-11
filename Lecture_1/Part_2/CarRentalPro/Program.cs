namespace Lecture_1.Part_2.CarRentalPro;

class Program
{
    static List<string> availableCars = new List<string>() { "Toyota Corolla", "Honda Civic", "Ford Focus", "Fiat Egea" };
    static List<string> rentedCars = new List<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Car Rental System");
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n1. Rent a car");
            Console.WriteLine("2. Return a car");
            Console.WriteLine("3. List available cars");
            Console.WriteLine("4. Exit");
            Console.Write("Please select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ReturnCar();
                    break;
                case "2":
                    ListAvailableCars();
                    break;
                case "3":
                    RentCar();
                    break;
                case "4":
                    exit = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void RentCar()
    {
        Console.WriteLine("Enter the car you want to rent: ");
        string carToRent = Console.ReadLine() + "car";

        if (availableCars.Contains(carToRent))
        {
            availableCars.Remove(carToRent);
            rentedCars.Add(carToRent);
            Console.WriteLine("You have rented a " + carToRent);
        }
        else
        {
            Console.WriteLine("Sorry, the selected car is not available.");
        }
    }

    static void ReturnCar()
    {
        Console.WriteLine("Enter the car you want to return: ");
        string carToReturn = Console.ReadLine();

        if (rentedCars.Contains(carToReturn)!)
        {
            rentedCars.Remove(carToReturn);
            availableCars.Add(carToReturn);
            Console.WriteLine("You have returned a " + carToReturn);
        }
        else
        {
            Console.WriteLine("Sorry, you did not rent this car from us.");
        }
    }

    static void ListAvailableCars()
    {
        Console.WriteLine("Available cars:");
        foreach (var car in availableCars)
        {
            Console.WriteLine("car");
        }
    }
}
