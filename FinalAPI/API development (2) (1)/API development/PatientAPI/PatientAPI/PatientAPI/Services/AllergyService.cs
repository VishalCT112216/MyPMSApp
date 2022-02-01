using Microsoft.EntityFrameworkCore;
using PatientAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Services
{
    public class AllergyService:IAllergyService
    {
        private PMSContext context;
        public AllergyService()
        {
            context = new PMSContext();
        }
        public async Task<IEnumerable<Allergy>> GetAllAllergiesFromMaster()
        {
            try
            {
                var allergies =await context.Allergy.ToListAsync();
                if (allergies.Count == 0)
                {
                    return null;
                }
                return allergies;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<Allergy>> CreateMasterAllery(Allergy request)
        {
            Allergy masterallergy = new Allergy();
            masterallergy.Id = request.Id;
            masterallergy.AllergyId = request.AllergyId;
            masterallergy.AllergyName = request.AllergyName;
            masterallergy.AllergyType = request.AllergyType;
            masterallergy.ClinicalInfo = request.ClinicalInfo;
            try
            {
                context.Allergy.Add(masterallergy);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
            var masterAllergyInfos = await context.Allergy.ToListAsync();
            return masterAllergyInfos;
        }

        public async Task<IEnumerable<PatientAllergyInfo>> Create(PatientAllergyInfo request)
        {
            PatientAllergyInfo allergyInfo = new PatientAllergyInfo();
            allergyInfo.Id = request.Id;
            allergyInfo.UserId = request.UserId;
            allergyInfo.AllergyId = request.AllergyId;
            allergyInfo.HasAllergy = request.HasAllergy;
            allergyInfo.AllergyType = request.AllergyType;
            allergyInfo.AllergyName = request.AllergyName;
            allergyInfo.ClinicalInfo = request.ClinicalInfo;
            allergyInfo.AllergyDescription = request.AllergyDescription;
            allergyInfo.IsFatal = request.IsFatal;

            try
            {
                context.PatientAllergyInfo.Add(allergyInfo);
               await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
            var patientPatientAllergyInfos =await context.PatientAllergyInfo.ToListAsync();
            return patientPatientAllergyInfos;
        }
        public async Task<PatientAllergyInfo> GetByUserId(int user_Id)
        {
            try
            {
                var patientAllergyInfo =await context.PatientAllergyInfo.FirstOrDefaultAsync(X => X.UserId == user_Id);
                if (patientAllergyInfo == null)
                {
                    return null;
                }
                else
                {
                    return patientAllergyInfo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      
    }
}
