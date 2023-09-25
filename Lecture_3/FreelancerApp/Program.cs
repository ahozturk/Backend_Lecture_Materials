using Lecture_3.Entities;
using Lecture_3.Services;

Console.WriteLine("Freelance!");

List<Customer> customers = new();

//Customer customer = new()
//{
//    Id = Guid.NewGuid(),
//    CreatedDate = DateTimeOffset.Now,
//    FirstName = "Name 2",
//    LastName = "Lastname 2"
//};

NotepadService notepadService = new();

string[] lines = notepadService.ReadNotepad().Split("\n", StringSplitOptions.RemoveEmptyEntries);

foreach (string line in lines)
{
    Customer customer = new();

    customer.SetValuesCSV("f749b8a5-f5b2-4bbc-a03d-085ec125b52b,9/25/2023 1:33:41 PM +03:00,Name 2,Lastname 2");

    customers.Add(customer);
}


Console.WriteLine();