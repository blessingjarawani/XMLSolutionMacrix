using System;
using System.Collections.Generic;
using System.Text;
using XMLSolutionMatrics.BLL.Infrastructure.Util;
using static XMLSolutionMatrics.BLL.Infrastructure.Shared.Dictionaries.Dictionaries;

namespace XMLSolutionMatrics.BLL.DTO
{
    public class AddPersonCommand
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
        public string ApartmentNumber { get; set; }
        public string PhoneNumber { get; set; }
        public Town Town { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age => new Age(this.DateOfBirth, DateTime.Today).Years;

        public bool IsValid =>
            !string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName)
            && !string.IsNullOrWhiteSpace(StreetName) && !string.IsNullOrWhiteSpace(PostalCode) &&
            !string.IsNullOrWhiteSpace(ApartmentNumber) || !string.IsNullOrWhiteSpace(PostalCode)
            && !string.IsNullOrWhiteSpace(PhoneNumber) || !Enum.TryParse<Town>(Town.ToString(), out var valid);


    }
}
