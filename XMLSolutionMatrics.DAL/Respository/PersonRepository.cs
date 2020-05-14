using System;
using System.Collections.Generic;
using System.Text;
using XMLSolutionMatrics.BLL.DTO;
using XMLSolutionMatrics.BLL.Entities;
using XMLSolutionMatrics.BLL.Infrastructure.Shared.Interfaces;
using XMLSolutionMatrics.BLL.Infrastructure.Shared.Responses;

namespace XMLSolutionMatrics.DAL.Respository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IFileService _fileService;
        public PersonRepository(IFileService fileService)
        {
            _fileService = fileService;
        }
        public Response<int> AddorUpdate(Person person)
        {
            return _fileService.AddOrUpdate(person);
        }

        public Response<bool> Delete(string[] id)
        {
            return _fileService.Delete(id);
        }

        public Response<List<PersonDTO>> GetAll()
        {
            return _fileService.GetAll();
        }
    }
}
