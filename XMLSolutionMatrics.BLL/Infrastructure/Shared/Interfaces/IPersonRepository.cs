using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using XMLSolutionMatrics.BLL.DTO;
using XMLSolutionMatrics.BLL.Entities;
using XMLSolutionMatrics.BLL.Infrastructure.Shared.Responses;

namespace XMLSolutionMatrics.BLL.Infrastructure.Shared.Interfaces
{
    public interface IPersonRepository
    {
        Response<int> AddorUpdate(Person person);
        Response<bool> Delete(string[] id);
        Response<List<PersonDTO>> GetAll();
    }
}
