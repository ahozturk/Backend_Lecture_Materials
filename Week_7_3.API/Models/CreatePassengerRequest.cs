using Week_7_3.Domain.Entities;

namespace Week_7_3.API.Models
{
    public class CreatePassengerRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public BankAccount? Account { get; set; }
    }  
}

