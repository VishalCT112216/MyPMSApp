using Microsoft.EntityFrameworkCore;
using PatientAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Services
{
    public class ProcedureService : IProcedureService
    {
        private PMSContext context;
        public ProcedureService()
        {
            context = new PMSContext();
        }
        public async Task<IEnumerable<PatientProcedureInfo>> Create(PatientProcedureInfo request)
        {
            PatientProcedureInfo procedureInfo = new PatientProcedureInfo();
            procedureInfo.Id = request.Id;
            //procedureInfo.UserId = request.UserId;
            procedureInfo.PatientId = request.PatientId;
            procedureInfo.PhysicianId = request.PhysicianId;
            procedureInfo.CreatedBy = request.CreatedBy;
            procedureInfo.ProcedureCode = request.ProcedureCode;
            procedureInfo.ProcedureDescription = request.ProcedureDescription;
            procedureInfo.ProcedureIsDepricated = request.ProcedureIsDepricated;
            procedureInfo.CreatedDate = DateTime.Now;

            try
            {
                context.PatientProcedureInfo.Add(procedureInfo);
              await  context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
            var patientProcedureInfos =await context.PatientProcedureInfo.ToListAsync();
            return patientProcedureInfos;
        }

        public async Task<IEnumerable<ProcedureData>> CreateMasterProcedure(ProcedureData request)
        {
            ProcedureData masterprocedureInfo = new ProcedureData();
            masterprocedureInfo.Id = request.Id;
            masterprocedureInfo.ProcedureId = request.ProcedureId;
            masterprocedureInfo.ProcedureCode = request.ProcedureCode;
            masterprocedureInfo.ProcedureDescription = request.ProcedureDescription;
            masterprocedureInfo.ProcedureIsDepricated = request.ProcedureIsDepricated;

            try
            {
                context.ProcedureData.Add(masterprocedureInfo);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
            var masterProcedureInfos = await context.ProcedureData.ToListAsync();
            return masterProcedureInfos;
        }

        public async Task<IEnumerable<ProcedureData>> GetAllProceduresFromMaster()
        {
            try
            {
                var procedures =await context.ProcedureData.ToListAsync();
                if (procedures.Count == 0)
                {
                    return null;
                }
                return procedures;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<PatientProcedureInfo>> GetByUserId(int user_Id)
        {
            try
            {
                var patientProcedureInfo =await context.PatientProcedureInfo.Where(X => X.PatientId == user_Id).ToListAsync();
                if (patientProcedureInfo == null)
                {
                    return null;
                }
                else
                {
                    return patientProcedureInfo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<PatientProcedureInfo>> Update(PatientProcedureInfo request)
        {
            try
            {
                var patientProcedureInfo =await context.PatientProcedureInfo.FirstOrDefaultAsync(X => X.PatientId == request.PatientId);
                if (patientProcedureInfo == null)
                {
                    return null;
                }
                patientProcedureInfo.Id = request.Id;
                // patientProcedureInfo.UserId = request.UserId;
                patientProcedureInfo.PatientId = request.PatientId;
                patientProcedureInfo.PhysicianId = request.PhysicianId;
                patientProcedureInfo.CreatedBy = request.CreatedBy;
                patientProcedureInfo.ProcedureCode = request.ProcedureCode;
                patientProcedureInfo.ProcedureDescription = request.ProcedureDescription;
                patientProcedureInfo.ProcedureIsDepricated = request.ProcedureIsDepricated;

                context.Entry(patientProcedureInfo).State = EntityState.Modified;
               await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var procedureInfos =await context.PatientProcedureInfo.ToListAsync();
            return procedureInfos;
        }
    }
}
