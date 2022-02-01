using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS3WEBAPIPROJECT.Models;
using PMS3WEBAPIPROJECT.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS3WEBAPIPROJECT.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulingController : ControllerBase
    {


        private static  IScheduling _schedulesServices;

        public SchedulingController(IScheduling schedulesServ)
        {
            _schedulesServices = schedulesServ;
        }

        [HttpGet("GetAllScheduling")]
        public IActionResult Get()
        {
            try
            {
                
                var logins = _schedulesServices.getallschedule();
               
                return Ok(logins);
            }
            catch (Exception ex)
            {
              
                return StatusCode(500, "An error has occured");
            }

        }

        [HttpGet("GetBySchedulingId/{id}")]
        public Scheduling GetById([FromRoute] int id)
        {
            return _schedulesServices.GetById(id);
        }

        [HttpGet("GetByUserId/{id}")]
        public Scheduling GetByUserId([FromRoute] int id)
        {
            return _schedulesServices.GetByUserId(id);
        }

        [HttpGet("GetAppointmentDetails/{RoleId}")]
        public IEnumerable<Scheduling> GetAppointmentDetails(int RoleId)
        {
            return _schedulesServices.GetByAppointment(RoleId);
        }

        [HttpGet("GetByPhysicianAppointment/{patientId}")]
        public IEnumerable<Scheduling> GetByPhysicianAppointment(int patientId)
        {
            return _schedulesServices.GetByPhysicianAppointment(patientId);
        }

        [HttpPost("CreateScheduling")]
        public IEnumerable<Scheduling> Create(Scheduling request)
        {
          return _schedulesServices.Create(request);
        }

        [HttpPut("UpdateScehduling")]
        public IEnumerable<Scheduling> Update([FromBody] Scheduling request)
        {
            return _schedulesServices.Update(request);
        }

        [HttpDelete("DeleteScheduling/{SchedulingId}")]
        public IEnumerable<Scheduling> Delete([FromRoute] int SchedulingId)
        {
            return _schedulesServices.Delete(SchedulingId);
        }
    }

}
