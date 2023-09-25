using Freelancer.Entities;
using Freelancer.Services;
using Freelancer.Common;
using Freelancer.Abstract;

Console.WriteLine("Hello, World!");



//ICsvConvertible freelancerInstance = new Freelancer.Entities.Freelancer()
//{
//    Id = Guid.NewGuid(),          // Replace with a valid GUID
//    CreatedOn = DateTime.Now,    // Replace with the creation date
//    FirstName = "John",
//    LastName = "Doe",
//    WorkExperience = "5 years of experience in web development",
//    Reviews = new List<Review>
//    {
//        new Review { Text = "Excellent freelancer!", Rating = 5 },
//        new Review { Text = "Great work!", Rating = 4 }
//    }
//};

var anotherCustomerInstance = new Customer
{
    Id = Guid.NewGuid(),          // Replace with a valid GUID
    CreatedOn = DateTime.Now,    // Replace with the creation date
    FirstName = "Bob",
    LastName = "Smith",
    PhoneNumber = "555-123-4567" // Replace with an actual phone number
};



NotepadService notepadService = new();
//notepadService.SaveToNotepad(anotherCustomerInstance);

string customerData =  notepadService.GetOnNotepad("C:\\Users\\ahmet\\OneDrive\\Documents\\GitHub\\Backend_Lecture_Materials\\Lecture_3\\Freelancer\\Database\\Customers.txt");

string[] splittedLines = customerData.Split("\n", StringSplitOptions.RemoveEmptyEntries);

List<Customer> customers = new();

foreach (var line in splittedLines)
{
    Customer customer = new();
    customer.SetValuesCSV(line);
    customers.Add(customer);
}