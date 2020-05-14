using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using static XMLSolutionMatrics.BLL.Infrastructure.Shared.Dictionaries.Dictionaries;

namespace XMLSolutionMatrics.BLL.DTO
{
    public class PersonDTO
    {
     
        public int Id { get;  set; }
     
        public string FirstName { get;  set; }
    
        public string LastName { get;  set; }

        public string StreetName { get;  set; }

        public string HouseNumber { get; set; }
     
        public string PostalCode { get;  set; }

        public string ApartmentNumber { get;  set; }

        public string PhoneNumber { get;  set; }

        public Town Town { get; set; }
   
        public DateTime DateOfBirth { get;  set; }
    }

    
   
}
