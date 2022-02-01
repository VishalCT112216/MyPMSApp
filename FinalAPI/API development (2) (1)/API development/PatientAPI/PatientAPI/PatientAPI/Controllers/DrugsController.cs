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
    public class DrugsController : ControllerBase
    {
        private static IDrugService _drugService;
        public DrugsController(IDrugService drugService)
        {
            _drugService = drugService;
        }

        //GetAll
        [HttpGet("GetAllDrugs")]
        public async Task<IActionResult> GetAll()
        {
            var listDrug = await _drugService.GetAllDrugsFromMaster();

            return Ok(listDrug);
        }

        [HttpPost("CreateMasterDrug")]
        public async Task<IActionResult> CreateMasterDrug(Drug request)
        {
            return Ok(await _drugService.CreateMasterDrug(request));
        }

        [HttpGet("GetByUserId/{user_Id}")]
        public async Task<IActionResult> GetByPatientMedicationId([FromRoute] int user_Id)
        {
            var PatientMedicationInfo = await _drugService.GetMedicationByUserId(user_Id);
            //if(user == null)
            //{
            //    return null;
            //}
            return Ok(PatientMedicationInfo);
        }

        [HttpPost("CreatePatientMedication")]
        public async Task<IActionResult> Create(PatientMedicationInfo request)
        {
            return Ok(await _drugService.Create(request));
        }

        [HttpPut("UpdatePatientMedication")]
        public async Task<IActionResult> Update([FromBody] PatientMedicationInfo request)
        {
            return Ok(await _drugService.Update(request));
        }
    }
}
