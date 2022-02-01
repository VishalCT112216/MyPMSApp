using PMSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMSAPI.Services
{
    public interface IAdmin
    {
        IEnumerable<Login> Get();
        IEnumerable<Login> GetByRole(int RoleId);
        Login GetById(int User_Id);
        IEnumerable<Login> Create(Login request);
        IEnumerable<Login> Update(Login request);
        IEnumerable<Login> Delete(int User_Id);




    }
}
