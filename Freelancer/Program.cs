using Freelancer.Entities;
using Freelancer.Services;
Console.WriteLine("Hello, World!");

//"Id,CreatedOn,FirstName,LastName,PhoneNumber"
//Id,CreatedOn,FirstName,LastName,PhoneNumber
//Id,CreatedOn,FirstName,LastName,PhoneNumber

string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
//C:\Users\ahmet\OneDrive\Documents\GitHub\Backend_Lecture_Materials\Freelancer\

Customer customer1 = new()
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTimeOffset.Now,
    FirstName = "Name Test 1",
    LastName = "Last Name Test 1",
    PhoneNumber = "0533 333 33 33"
};

Console.WriteLine(customer1.GetValuesCSV());

NotepadService notepadService = new();
//notepadService.SaveToNotepad(path, );