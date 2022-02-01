using Microsoft.EntityFrameworkCore;
using PatientAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Services
{
    public class VitalSignService : IVitalSignService
    {
        private PMSContext context;
        public VitalSignService()
        {
            context = new PMSContext();
        }
        public async Task<IEnumerable<PatientVitalSignInfo>> Create(PatientVitalSignInfo request)
        {
            PatientVitalSignInfo vitalSignInfo = new PatientVitalSignInfo();
            vitalSignInfo.Id = request.Id;
            vitalSignInfo.PatientId = request.PatientId;
            vitalSignInfo.PhysicianId = request.PhysicianId;
            vitalSignInfo.CreatedBy = request.CreatedBy;
            vitalSignInfo.Height = request.Height;
            vitalSignInfo.Weight = request.Weight;
            vitalSignInfo.BloodPressure = request.BloodPressure;
            vitalSignInfo.BodyTemperature = request.BodyTemperature;
            vitalSignInfo.RespirationRate = request.RespirationRate;
            vitalSignInfo.CreatedDate = DateTime.Now;

            try
            {
                context.PatientVitalSignInfo.Add(vitalSignInfo);
               await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
            var patientVitalSignInfos =await context.PatientVitalSignInfo.ToListAsync();
            return patientVitalSignInfos;
        }

        public async Task<IEnumerable<PatientVitalSignInfo>> GetByUserId(int user_Id)
        {
            try
            {
                var patientVitalInfo =await context.PatientVitalSignInfo.Where(X => X.PatientId == user_Id).ToListAsync();
                if (patientVitalInfo == null)
                {
                    return null;
                }
                else
                {
                    return patientVitalInfo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<PatientVitalSignInfo>> Update(PatientVitalSignInfo request)
        {
            try
            {
                var patientVitalInfo =await context.PatientVitalSignInfo.FirstOrDefaultAsync(X => X.PatientId == request.PatientId);
                if (patientVitalInfo == null)
                {
                    return null;
                }
                patientVitalInfo.Id = request.Id;
                patientVitalInfo.PatientId = request.PatientId;
                patientVitalInfo.PhysicianId = request.PhysicianId;
                patientVitalInfo.CreatedBy = request.CreatedBy;
                patientVitalInfo.Height = request.Height;
                patientVitalInfo.Weight = request.Weight;
                patientVitalInfo.BloodPressure = request.BloodPressure;
                patientVitalInfo.BodyTemperature = request.BodyTemperature;
                patientVitalInfo.RespirationRate = request.RespirationRate;

                context.Entry(patientVitalInfo).State = EntityState.Modified;
               await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var vitalInfos =await context.PatientVitalSignInfo.ToListAsync();
            return vitalInfos;
        }
    }
}
