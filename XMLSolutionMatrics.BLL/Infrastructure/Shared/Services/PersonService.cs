using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XMLSolutionMatrics.BLL.DTO;
using XMLSolutionMatrics.BLL.Entities;
using XMLSolutionMatrics.BLL.Infrastructure.Shared.Interfaces;
using XMLSolutionMatrics.BLL.Infrastructure.Shared.Responses;

namespace XMLSolutionMatrics.BLL.Infrastructure.Shared.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public Response<int> AddOrUpdate(AddPersonCommand addPersonCommand)
        {
            try
            {
                if (addPersonCommand == null || !addPersonCommand.IsValid)
                {
                    return new Response<int> { Success = false, Message = "Invalid Person" };
                }
                var person = new Person(addPersonCommand.Id, addPersonCommand.FirstName, addPersonCommand.LastName, addPersonCommand.StreetName, addPersonCommand.HouseNumber, addPersonCommand.PostalCode,
                    addPersonCommand.ApartmentNumber, addPersonCommand.PhoneNumber, addPersonCommand.DateOfBirth, addPersonCommand.Town);
             
                var response = _personRepository.AddorUpdate(person);
                return response.Success ?
                    new Response<int> { Success = true, Data = response.Data} : new Response<int> { Success = false, Message = response.Message };
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
                if (id?.Any() == true)
                {
                    return _personRepository.Delete(id);
                }
                return new Response<bool> { Success = false, Message = "Invalid ID" };
            }
            catch (Exception ex)
            {
                return new Response<bool> { Success = false, Message = ex.GetBaseException().Message };
            }
        }

        public Response<List<Person>> GetAll()
        {
            try
            {

                var result = _personRepository.GetAll();
                if (!result.Success)
                {
                    return new Response<List<Person>> { Success = false, Message = result.Message };
                }
                var personList = result.Data?.Select(x => new
                    Person
                    (
                      x.Id, x.FirstName, x.LastName, x.StreetName, x.HouseNumber, x.PostalCode, x.ApartmentNumber, x.PhoneNumber, x.DateOfBirth, x.Town)
                    )?.ToList();
                return new Response<List<Person>> { Success = true, Data = personList };
            }
            catch (Exception ex)
            {
                return new Response<List<Person>> { Success = false, Message = ex.GetBaseException().Message };
            }
        }

    }
}
