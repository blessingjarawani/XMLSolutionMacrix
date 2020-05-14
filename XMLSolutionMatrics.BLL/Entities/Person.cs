using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XMLSolutionMatrics.BLL.Infrastructure.Util;
using static XMLSolutionMatrics.BLL.Infrastructure.Shared.Dictionaries.Dictionaries;

namespace XMLSolutionMatrics.BLL.Entities
{
    [XmlRoot(Namespace = "wwww.test.com",
     ElementName = "Persons",
     DataType = "string",
     IsNullable = true)]
    public class Person
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string StreetName { get; private set; }
        public string HouseNumber { get; private set; }
        public string PostalCode { get; private set; }
        public string ApartmentNumber { get; private set; }
        public string PhoneNumber { get; private set; }
        public Town Town { get; set; }
        public DateTime DateOfBirth { get; private set; }
        public int Age => new Age(this.DateOfBirth, DateTime.Today).Years;
        public Person(int id, string firstName, string lastName, string streetName, string houseNumber, string postalCode,
            string apartmentNumber, string phoneNumber, DateTime dateOfBirth, Town town)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            StreetName = streetName;
            PostalCode = postalCode;
            StreetName = streetName;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            HouseNumber = houseNumber;
            ApartmentNumber = apartmentNumber;
            Town = town;
        }
     
    }
}
