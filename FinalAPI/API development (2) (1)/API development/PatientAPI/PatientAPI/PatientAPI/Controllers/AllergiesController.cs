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
    public class AllergiesController : ControllerBase
    {
        private static IAllergyService _allergyService;
        public AllergiesController(IAllergyService allergyService)
        {
            _allergyService = allergyService;
        }

        //GetAll
        [HttpGet("GetAllAllergies")]
        public async Task<IActionResult> GetAll()
        {
            var listAllergy =await _allergyService.GetAllAllergiesFromMaster();
             

            return Ok(listAllergy);
        }

        //Create master allergy
        [HttpPost("CreateMasterAllergy")]
        public async Task<IActionResult> CreateMasterAllergy(Allergy request)
        {
            return Ok(await _allergyService.CreateMasterAllery(request));
        }

        //GetUserById
        [HttpGet("GetByUserId/{user_Id}")]
        public async Task<IActionResult> GetByUserId([FromRoute] int user_Id)
        {
            var patientDemoInfo =await _allergyService.GetByUserId(user_Id);
            //if(user == null)
            //{
            //    return null;
            //}
            return Ok(patientDemoInfo);
        }

        //Create User
        [HttpPost("CreatePatientAllergyInfo")]
        public async Task<IActionResult> Create(PatientAllergyInfo request)
        {
            return Ok(await _allergyService.Create(request));
        }
    }
}
