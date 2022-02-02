using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PatientAPI.Models;

namespace PatientAPI.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProceduresController : ControllerBase
    {
        private static IProcedureService _procedureService;
        public ProceduresController(IProcedureService procedureService)
        {
            _procedureService = procedureService;
        }

        //GetAll
        [HttpGet("GetAllProcedures")]
        public async Task<IActionResult> GetAll()
        {
            var listProcedure =await _procedureService.GetAllProceduresFromMaster();

            return Ok(listProcedure);
        }
        [HttpPost("CreateMasterProcedure")]
        public async Task<ActionResult> CreateMasterProcedure(ProcedureData request)
        {
            return Ok(await _procedureService.CreateMasterProcedure(request));
        }


        //GetUserById
        [HttpGet("GetByUserId/{user_Id}")]
        public async Task<IActionResult> GetByUserId([FromRoute] int user_Id)
        {
            var patientProcedureInfo =await _procedureService.GetByUserId(user_Id);
            //if(user == null)
            //{
            //    return null;
            //}
            return  Ok(patientProcedureInfo);
        }

        //Create User
        [HttpPost("CreateProcedureInfo")]
        public async Task<ActionResult> Create(PatientProcedureInfo request)
        {
            return Ok(await _procedureService.Create(request));
        }

        //Update User
        [HttpPut("UpdateProcedureInfo")]
        public async Task<IActionResult> Update([FromBody] PatientProcedureInfo request)
        {
            return Ok(await _procedureService.Update(request));
        }
    }
}
