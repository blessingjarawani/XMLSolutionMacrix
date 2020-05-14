using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using XMLSolutionMatrics.BLL.DTO;
using XMLSolutionMatrics.BLL.Entities;
using XMLSolutionMatrics.BLL.Infrastructure.Shared.Interfaces;
using XMLSolutionMatrics.BLL.Infrastructure.Shared.Responses;
using XMLSolutionMatrics.BLL.Infrastructure.Util;
using static XMLSolutionMatrics.BLL.Infrastructure.Shared.Dictionaries.Dictionaries;

namespace XMLSolutionMatrics.BLL.Infrastructure.Shared.Services
{
    public class FileService : IFileService
    {

        private string @fileName =Path.Combine (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),"person.xml");
        public FileService()
        {
            ConfigFile();

        }

        public Response<int> AddOrUpdate(Person person)
        {
            try
            {
                var result = GetById(person.Id);
                if (!result.Success)
                {
                    return AddNewPerson(person);
                }
                return Update(person);
            }


            catch (Exception ex)
            {
                return new Response<int> { Success = false, Message = ex.GetBaseException().Message };
            }
        }


        private Response<int> AddNewPerson(Person person)
        {
            try
            {
                var id = GenerateId();
                var xmlDocument = XDocument.Load(@fileName);
                xmlDocument.Elements("Persons").First()
                .Add(new XElement("Person", new XElement("Id", id),
                new XElement("FirstName", person.FirstName),
                new XElement("LastName", person.LastName),
                new XElement("StreetName", person.StreetName),
                new XElement("PostalCode", person.PostalCode),
                new XElement("ApartmentNumber", person.ApartmentNumber),
                new XElement("PhoneNumber", person.PhoneNumber),
                new XElement("Town", person.Town),
                new XElement("DateOfBirth", person.DateOfBirth)));
                xmlDocument.Save(@fileName);
                return new Response<int> { Success = true, Data = id };
            }
            catch (Exception ex)
            {
                return new Response<int> { Success = false, Message = ex.GetBaseException().Message };
            }
        }

        public Response<List<PersonDTO>> GetAll()
        {
            try
            {
                var xmlDocument = XDocument.Load(@fileName);
                var result = xmlDocument.Elements("Persons").Elements("Person")?.Select(x =>
                                  new PersonDTO
                                  {
                                      Id = int.Parse(x.Element("Id")?.Value),
                                      FirstName = x.Element("FirstName")?.Value,
                                      LastName = x.Element("LastName")?.Value,
                                      StreetName = x.Element("StreetName")?.Value,
                                      HouseNumber = x.Element("HouseNumber")?.Value,
                                      ApartmentNumber = x.Element("ApartmentNumber")?.Value,
                                      Town = (Town)Enum.Parse(typeof(Town), x.Element("Town")?.Value),
                                      DateOfBirth = DateTime.Parse(x.Element("DateOfBirth").Value),
                                      PostalCode = x.Element("PostalCode")?.Value,
                                      PhoneNumber = x.Element("PhoneNumber")?.Value

                                  })?.ToList();


                return new Response<List<PersonDTO>> { Success = true, Data = result };

            }
            catch (Exception ex)
            {
                return new Response<List<PersonDTO>> { Success = false, Message = ex.GetBaseException().Message };
            }

        }


        private Response<XElement> GetById(int id)
        {
            try
            {
                var xmlDocument = XDocument.Load(@fileName);
                var result = xmlDocument.Elements("Persons").Elements("Person")?
                    .FirstOrDefault(x => x.Element("Id")?.Value == id.ToString());
                return result != null ? new Response<XElement> { Success = true, Data = result } :
                    new Response<XElement> { Success = false, Message = "Object not found" };
            }
            catch (Exception ex)
            {
                return new Response<XElement> { Success = false, Message = ex.GetBaseException().Message };
            }

        }

        private Response<int> Update(Person person)
        {
            try
            {
                var xmlDocument = XDocument.Load(@fileName);
                var result = xmlDocument.Elements("Persons").Elements("Person")?
                   .FirstOrDefault(x => x.Element("Id")?.Value == person.Id.ToString());
                if (result != null)
                {

                    result.Element("FirstName").Value = person.FirstName;
                    result.Element("LastName").Value = person.LastName;
                    result.Element("StreetName").Value = person.StreetName;
                    result.Element("PostalCode").Value = person.PostalCode;
                    result.Element("ApartmentNumber").Value = person.ApartmentNumber;
                    result.Element("PhoneNumber").Value = person.PhoneNumber;
                    result.Element("Town").Value = person.Town.ToString();
                    result.Element("DateOfBirth").Value = person.DateOfBirth.ToShortDateString();
                    xmlDocument.Save(@fileName);
                    return new Response<int> { Success = true, Data = person.Id };
                }


                return new Response<int> { Success = false, Message = "Object not found" };

            }
            catch (Exception ex)
            {
                return new Response<int> { Success = false, Message = ex.GetBaseException().Message };
            }

        }

        public Response<bool> Delete(string[] id)
        {
            try
            {
                var xmlDocument = XDocument.Load(@fileName);
                var elementToDelete = xmlDocument.Elements("Persons").Elements("Person")
                 .Where(x => id.Contains(x.Element("Id")?.Value));
                 elementToDelete.Remove();
                xmlDocument.Save(@fileName);
                return new Response<bool> { Success = true };
            }
            catch (Exception ex)
            {
                return new Response<bool> { Success = false, Message = ex.GetBaseException().Message };
            }

        }

        private int GenerateId()
        {
            var xmlDocument = XDocument.Load(@fileName);
            return xmlDocument.Elements("Persons").Elements("Person")?.Count() + 1 ?? 1;
        }

        private bool ConfigFile()
        {
            try
            {
                if (!File.Exists(@fileName))
                {

                    var xmlFile = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                      new XComment("XML File for storing Persons"));
                    xmlFile.Add(new XElement("Persons"));
                    xmlFile.Save(@fileName);

                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
