using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientAPI.Models;
using PatientAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class VitalInfosController : ControllerBase
    {
        private static IVitalSignService _patientVitalInfo;
        public VitalInfosController(IVitalSignService patientVitalInfo)
        {
            _patientVitalInfo = patientVitalInfo;
        }

        //GetUserById
        [HttpGet("GetByUserId/{user_Id}")]
        public async Task<IActionResult> GetByUserId([FromRoute] int user_Id)
        {
            var patientVitalInfo =await _patientVitalInfo.GetByUserId(user_Id);
            //if(user == null)
            //{
            //    return null;
            //}
            return Ok(patientVitalInfo);
        }

        //Create User
        [HttpPost("CreateVitalInfo")]
        public async Task<IActionResult> Create(PatientVitalSignInfo request)
        {
            return Ok(await _patientVitalInfo.Create(request));
        }

        //Update User
        [HttpPut("UpdateVitalInfo")]
        public async Task<IActionResult> Update([FromBody] PatientVitalSignInfo request)
        {
            return Ok(await _patientVitalInfo.Update(request));
        }
    }
}
