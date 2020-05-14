using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using XMLSolutionMatrics.BLL.DTO;
using XMLSolutionMatrics.BLL.Entities;
using XMLSolutionMatrics.BLL.Infrastructure.Shared.Responses;

namespace XMLSolutionMatrics.BLL.Infrastructure.Shared.Interfaces
{
    public interface IFileService
    {
       
        Response<bool> Delete(string[] id);
        Response<List<PersonDTO>> GetAll();
        Response<int> AddOrUpdate(Person person);
        
    }
}
