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
    public class DiagnosisController : ControllerBase
    {
        private static IDiagnosisService _diagnosisService;
        public DiagnosisController(IDiagnosisService diagnosisService)
        {
            _diagnosisService = diagnosisService;
        }

        //GetAll
        [HttpGet("GetAllDiagnosis")]
        public async Task<IActionResult> GetAll()
        {
            var listDiagnosis =await _diagnosisService.GetAllDiagnosisFromMaster();

            return Ok(listDiagnosis);
        }

        [HttpPost("CreateMasterDiagnosis")]
        public async Task<IActionResult> CreateMasterDiagnosis(Diagnosis request)
        {
            return Ok(await _diagnosisService.CreateMasterDiagnosis(request));
        }

        [HttpGet("GetByUserId/{user_Id}")]
        public async Task<IActionResult> GetByPatientDiagnosisId([FromRoute] int user_Id)
        {
            var patientDiagnosisInfo = await _diagnosisService.GetDiagnosisByUserId(user_Id);
            //if(user == null)
            //{
            //    return null;
            //}
            return Ok(patientDiagnosisInfo);
        }


        [HttpPost("CreatePatientDiagnosis")]
        public async Task<IActionResult> Create(PatientDiagnosisInfo request)
        {
            return Ok(await _diagnosisService.Create(request));
        }

        [HttpPut("UpdatePatientDiagnosis")]
        public async  Task<IActionResult> Update([FromBody] PatientDiagnosisInfo request)
        {
            return Ok(await _diagnosisService.Update(request));
        }



    }
}
