using System;
using System.Collections.Generic;
using System.Text;
using XMLSolutionMatrics.BLL.DTO;
using XMLSolutionMatrics.BLL.Entities;
using XMLSolutionMatrics.BLL.Infrastructure.Shared.Responses;

namespace XMLSolutionMatrics.BLL.Infrastructure.Shared.Interfaces
{
    public interface IPersonService
    {
        Response<int> AddOrUpdate(AddPersonCommand addPersonCommand);
        Response<bool> Delete(string[] id);
        Response<List<Person>> GetAll();
    }
}
