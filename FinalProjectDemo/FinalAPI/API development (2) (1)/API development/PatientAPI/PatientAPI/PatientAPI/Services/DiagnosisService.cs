using Microsoft.EntityFrameworkCore;
using PatientAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Services
{
    public class DiagnosisService : IDiagnosisService
    {
        private PMSContext context;
        public DiagnosisService()
        {
            context = new PMSContext();
        }
        public async Task<IEnumerable<PatientDiagnosisInfo>> Create(PatientDiagnosisInfo request)
        {

            PatientDiagnosisInfo diagnosisInfo = new PatientDiagnosisInfo();
            diagnosisInfo.Id = request.Id;
            diagnosisInfo.PatientDiagnosisInfoId = request.PatientDiagnosisInfoId;
            diagnosisInfo.PatientId = request.PatientId;
            diagnosisInfo.PhysicianId = request.PhysicianId;
            diagnosisInfo.CreatedBy = request.CreatedBy;
            diagnosisInfo.DiagnosisCode = request.DiagnosisCode;
            diagnosisInfo.DiagnosisDescription = request.DiagnosisDescription;
            diagnosisInfo.DiagnosisIsDepricated = request.DiagnosisIsDepricated;
            diagnosisInfo.CreatedDate = DateTime.Now;

            try
            {
                context.PatientDiagnosisInfo.Add(diagnosisInfo);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
            var diagnosisInfos = await context.PatientDiagnosisInfo.ToListAsync();
            return diagnosisInfos;
        }

        public async Task<IEnumerable<Diagnosis>> CreateMasterDiagnosis(Diagnosis request)
        {
            Diagnosis masterdiagnosis = new Diagnosis();
            masterdiagnosis.Id = request.Id;
            masterdiagnosis.DiagnosisId = request.DiagnosisId;
            masterdiagnosis.DiagnosisCode = request.DiagnosisCode;
            masterdiagnosis.DiagnosisDescription = request.DiagnosisDescription;
            masterdiagnosis.DiagnosisIsDepricated = request.DiagnosisIsDepricated;
           
        

            try
            {
                context.Diagnosis.Add(masterdiagnosis);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex; 
            }
            var masterdiagnosisinfo = await context.Diagnosis.ToListAsync();
            return masterdiagnosisinfo;
        }

        public async Task<IEnumerable<Diagnosis>> GetAllDiagnosisFromMaster()
        {
            try
            {
                var diagnosis = await context.Diagnosis.ToListAsync();
                if (diagnosis.Count == 0)
                {
                    return null;
                }
                return diagnosis;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<PatientDiagnosisInfo>> GetDiagnosisByUserId(int User_Id)
        {

            try
            {
                var PatientDiagnosisInfos = await context.PatientDiagnosisInfo.Where(X => X.PatientId == User_Id).ToListAsync();
                if (PatientDiagnosisInfos == null)
                {
                    return null;
                }
                else
                {
                    return PatientDiagnosisInfos;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<PatientDiagnosisInfo>> Update(PatientDiagnosisInfo request)
        {
            try
            {
                var PatientDiagnosisInfo = await context.PatientDiagnosisInfo.FirstOrDefaultAsync(X => X.PatientId == request.PatientId);
                if (PatientDiagnosisInfo == null)
                {
                    return null;
                }
                PatientDiagnosisInfo.Id = request.Id;
                //PatientDiagnosisInfo.PatientDiagnosisInfoId = request.PatientDiagnosisInfoId;
                PatientDiagnosisInfo.PatientId = request.PatientId;
                PatientDiagnosisInfo.PhysicianId = request.PhysicianId;
                PatientDiagnosisInfo.CreatedBy = request.CreatedBy;
                PatientDiagnosisInfo.DiagnosisCode = request.DiagnosisCode;
                PatientDiagnosisInfo.DiagnosisDescription = request.DiagnosisDescription;
                PatientDiagnosisInfo.DiagnosisIsDepricated = request.DiagnosisIsDepricated;


                context.Entry(PatientDiagnosisInfo).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var DiagisisInfos = await context.PatientDiagnosisInfo.ToListAsync();
            return DiagisisInfos;
        }
    }

}
