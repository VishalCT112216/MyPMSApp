using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PMSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSAPI.Services
{
    public class Admin:IAdmin
    {

        private PMSContext context;

        public Admin()
        {
            context = new PMSContext();
        }

        //GetAll Users
       // [HttpGet("GetUsers")]
        public IEnumerable<Login> Get()
        {
            try
            {
                var logins = context.Login.ToList();
                if (logins.Count == 0)
                {
                    return null;
                }
                return logins;
            }
            catch (Exception ex)
            {


               throw ex;
            }

        }

         public IEnumerable<Login> GetByRole(int RoleId)
       {
            try
            {
                var user = context.Login.Where(X => X.RoleId == RoleId).ToList();
                if (user == null)
                {
                    return null;
                }
                else
                {
                    return user;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // [HttpGet("GetUserById/{User_Id}")]
        public Login GetById([FromRoute] int User_Id)
        {

            try
            {
                var user = context.Login.FirstOrDefault(X => X.UserId == User_Id);
                if (user == null)
                {
                    return null;
                }
                else
                {
                    return  user;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            // var logins = context.Login.ToList();
            // return Ok();

        }


        //[HttpPost("CreateUser")]
        public IEnumerable<Login> Create(Login request)
        {
            //int length = 10;
            //const string valid = "abcdefghijklmnopqrstuvlxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890@#$%^&*()!";
            //StringBuilder res = new StringBuilder();
            //Random rs = new Random();
            //while (0 < length--)
            //{
            //    res.Append(valid[rs.Next(valid.Length)]);
            //}
            string Password = "";
            if (request.Password==null)
            {
                 Password = "1@Demouser";
            }
            else
            {
                 Password = request.Password;
            }

            //res.ToString();
            //user.Password = res.ToString();
            Login user = new Login();
            user.Id = request.Id;
            //user.User_Id = request.User_Id;
            user.Username = request.Username;
            user.Password = Password;
            user.OldPassword = Password;
            user.Title = request.Title;
            user.Firstname = request.Firstname;
            user.Lastname = request.Lastname;
            user.EmailId = request.EmailId;
            user.Dob = Convert.ToDateTime(request.Dob);
            if (user.Dob == Convert.ToDateTime("1/1/0001 12:00:00 AM"))
            {
                user.Dob = Convert.ToDateTime("12/11/2000 12:00:00 AM");
            }
            user.Doj = Convert.ToDateTime(request.Doj);
            if(user.Doj==Convert.ToDateTime("1/1/0001 12:00:00 AM"))
            {
                user.Doj= Convert.ToDateTime("11/12/2002 12:00:00 AM");
            }
            user.ContactNo = request.ContactNo;
            user.Status = request.Status;
            user.RoleId = request.RoleId;
            user.IsActive = Convert.ToBoolean(1);
            user.CreatedDate = DateTime.Now; //Convert.ToDateTime(request.CreatedDate);
            user.CreatedBy = request.CreatedBy;

            try
            {
                context.Login.Add(user);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
            var logins = context.Login.ToList();
            return logins;
        }


       // [HttpPut("UpdateUser")]
        public IEnumerable<Login> Update([FromBody] Login request)
        {
            try
            {
                var user = context.Login.FirstOrDefault(X => X.UserId == request.UserId);
                if (user == null)
                {
                    return null;
                }
                user.Title = request.Title;
                user.Firstname = request.Firstname;
                user.Lastname = request.Lastname;
                user.EmailId = request.EmailId;
                user.Dob = request.Dob;
                user.Status = request.Status;
                user.Doj = request.Doj;
                user.ContactNo = request.ContactNo;
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var logins = context.Login.ToList();
            return logins;
        }


       // [HttpDelete("DeleteUser/{User_Id}")]
        public IEnumerable<Login> Delete([FromRoute] int User_Id)
        {
            try
            {
                var user = context.Login.FirstOrDefault(X => X.UserId == User_Id);
                if (user == null)
                {
                    return null;
                }
                context.Entry(user).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            var logins = context.Login.ToList();
            return logins;
        }
    }
}
