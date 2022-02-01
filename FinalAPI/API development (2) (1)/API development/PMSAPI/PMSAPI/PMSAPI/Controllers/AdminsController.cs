using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PMSAPI.Models;
using Microsoft.EntityFrameworkCore;
using PMSAPI.Services;
using Microsoft.AspNetCore.Cors;
//using Microsoft.AspNetCore.Authorization;

namespace PMSAPI.Controllers
{
    //Authrization
    //[Authorize(Roles = "Admin,Patient,Nurse")]
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private static IAdmin _admin;
        public AdminsController(IAdmin admin)
        {
            _admin = admin;
        }

       //GetAll
        [HttpGet("GetAllUser")]
        public IEnumerable<Login> GetAll()
        {
            
                var List = _admin.Get();
            
               // return StatusCode(404, "no user found");
            
          

          return List;
        }

        [HttpGet("GetByRoleId/{RoleId}")]
        public IEnumerable<Login> GetByRole(int RoleId)
        {
          return  _admin.GetByRole(RoleId);
        }



       //GetUserById
        [HttpGet("GetUserById/{User_Id}")]
        public Login GetById([FromRoute] int User_Id)
        {
            var user = _admin.GetById(User_Id);
            //if(user == null)
            //{
            //    return null;
            //}
            return user;
        }



       //Create User
        [HttpPost("CreateUser")]
        public IEnumerable<Login> Create(Login request)
        {
           return _admin.Create(request);
        }

       //Update User
         [HttpPut("UpdateUser")]
        public IEnumerable<Login> Update([FromBody] Login request)
        {
            return _admin.Update(request);
        }

       //Delete User
         [HttpDelete("DeleteUser/{User_Id}")]
        public IEnumerable<Login> Delete([FromRoute] int User_Id)
        {
          return  _admin.Delete(User_Id);
        }


    }
}
