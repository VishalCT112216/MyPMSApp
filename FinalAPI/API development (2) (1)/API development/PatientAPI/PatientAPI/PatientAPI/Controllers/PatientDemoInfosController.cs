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
    public class PatientDemoInfosController : ControllerBase
    {
        private static IPatientDemographicInformationService _patientDemoInfo;
        public PatientDemoInfosController(IPatientDemographicInformationService patientDemoInfo)
        {
            _patientDemoInfo = patientDemoInfo;
        }                

        //GetUserById
        [HttpGet("GetByUserId/{user_Id}")]
        public async Task<IActionResult> GetByUserId([FromRoute] int user_Id)
        {
            var patientDemoInfo =await _patientDemoInfo.GetByUserId(user_Id);
            //if(user == null)
            //{
            //    return null;
            //}
            return Ok( patientDemoInfo);
        }

        //Create User
        [HttpPost("CreateDemoInfo")]
        public async Task<IActionResult> Create(PatientDemoInfo request)
        {
            return Ok(await _patientDemoInfo.Create(request));
        }

        //Update User
        [HttpPut("UpdateDemoInfo")]
        public async Task<IActionResult> Update([FromBody] PatientDemoInfo request)
        {
            return Ok(await _patientDemoInfo.Update(request));
        }


        [HttpGet("GetAllPatientDemoInfos")]
        public async Task<IActionResult> GetAll()
        {
            var listPatientDemoInfos =await _patientDemoInfo.GetAllPatientDemoInfo();

            return Ok(listPatientDemoInfos);
        }
    }
}
