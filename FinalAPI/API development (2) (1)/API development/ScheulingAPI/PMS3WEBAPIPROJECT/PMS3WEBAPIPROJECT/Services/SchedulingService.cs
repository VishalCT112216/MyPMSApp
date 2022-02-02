using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PMS3WEBAPIPROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS3WEBAPIPROJECT.Services
{
    public class SchedulingService:IScheduling
    {
        private PMSContext _dbContext;
        public SchedulingService(PMSContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Scheduling> getallschedule()
        {
            try
            {
                var schedules = _dbContext.Scheduling.ToList();
                return schedules;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        
        public IEnumerable<Scheduling> Create(Scheduling request)
        {

            
            Scheduling user = new Scheduling();
            //user.SchedulingId = request.SchedulingId;  //PK
            //ser.User_Id = request.User_Id;
           // user.RId = request.RId;
            user.MeetingTitle = request.MeetingTitle;
            user.DescriptiveInformation = request.DescriptiveInformation;
            user.DateOfAppointment = request.DateOfAppointment;
            user.TimeOfAppointment = request.TimeOfAppointment;
            user.PhysicianId = request.PhysicianId;
            user.PatientId = request.PatientId;
            user.CreatedBy = request.CreatedBy;
           
             try
            {
                _dbContext.Scheduling.Add(user);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
            var schedulings = _dbContext.Scheduling.ToList();
            return schedulings;

        }

        public IEnumerable<Scheduling> Update([FromBody] Scheduling request)
        {
            try
            {
                var user = _dbContext.Scheduling.FirstOrDefault(X => X.SchedulingId == request.SchedulingId);
                if (user == null)
                {
                    return null;
                }
                //user.RId = request.RId;
                user.MeetingTitle = request.MeetingTitle;
                user.DescriptiveInformation = request.DescriptiveInformation;
                user.DateOfAppointment = request.DateOfAppointment;
                user.TimeOfAppointment = request.TimeOfAppointment;
                user.PhysicianId = request.PhysicianId;
                user.PatientId = request.PatientId;
               


                _dbContext.Entry(user).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var schedulings = _dbContext.Scheduling.ToList();
            return schedulings;
        }

       public IEnumerable<Scheduling> Delete(int SchedulingId)
        {
            try
            {
                var user = _dbContext.Scheduling.FirstOrDefault(X => X.SchedulingId == SchedulingId);
                if (user == null)
                {
                    return null;
                }
                _dbContext.Entry(user).State = EntityState.Deleted;
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            var Schedulings = _dbContext.Scheduling.ToList();
            return Schedulings;
        }

      
        public Scheduling GetById([FromRoute] int id)
        {
            try
            {
                var user = _dbContext.Scheduling.FirstOrDefault(X => X.SchedulingId == id);
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

        //[HttpGet("GetByUserId")]
        public Scheduling GetByUserId([FromRoute] int id)
        {
            try
            {
                var user = _dbContext.Scheduling.FirstOrDefault(X => X.CreatedBy == id);
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

       

        public IEnumerable<Scheduling> GetByAppointment(int createdbyid)
        {
            try
            {
                var user = _dbContext.Scheduling.Where(X => X.CreatedBy == createdbyid).ToList();
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

        public IEnumerable<Scheduling> GetByPhysicianAppointment(int patientId)
        {
            try
            {
                var user = _dbContext.Scheduling.Where(X => X.PhysicianId == patientId).ToList();
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
    }
}
