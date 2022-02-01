using Microsoft.EntityFrameworkCore;
using PatientAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Services
{
    public class DrugService : IDrugService
    {
        private PMSContext context;
        public DrugService()
        {
            context = new PMSContext();
        }
        public  async Task<IEnumerable<Drug>> GetAllDrugsFromMaster()
        {
            try
            {
                var drugs = await context.Drug.ToListAsync();
                if (drugs.Count == 0)
                {
                    return null;
                }
                return drugs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<Drug>> CreateMasterDrug(Drug request)
        {
            Drug masterDrug = new Drug();
            masterDrug.Id = request.Id;
            masterDrug.DrugId = request.DrugId;
            masterDrug.DrugName = request.DrugName;
            masterDrug.DrugGenericName = request.DrugGenericName;
            masterDrug.DrugBrandName = request.DrugBrandName;
            masterDrug.DrugForm = request.DrugForm;
            masterDrug.DrugStrength = request.DrugStrength;



            try
            {
                context.Drug.Add(masterDrug);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
            var masterdruginfo = context.Drug.ToList();
            return masterdruginfo;
        }
        public async Task<IEnumerable<PatientMedicationInfo>> GetMedicationByUserId(int User_Id)
        {

            try
            {
                var PatientMedicationInfo =await context.PatientMedicationInfo.Where(X => X.PatientId == User_Id).ToListAsync();
                if (PatientMedicationInfo == null)
                {
                    return null;
                }
                else
                {
                    return PatientMedicationInfo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<PatientMedicationInfo>> Create(PatientMedicationInfo request)
        {
            PatientMedicationInfo medicationInfo = new PatientMedicationInfo();
            medicationInfo.Id = request.Id;
            medicationInfo.PatientMedicationInfoId = request.PatientMedicationInfoId;
            //medicationInfo.UserId = request.UserId;
            medicationInfo.PatientId = request.PatientId;
            medicationInfo.PhysicianId = request.PhysicianId;
            medicationInfo.CreatedBy = request.CreatedBy;
            medicationInfo.DrugId = request.DrugId;
            medicationInfo.DrugName = request.DrugName;
            medicationInfo.DrugGenericName = request.DrugGenericName;
            medicationInfo.DrugBrandName = request.DrugBrandName;
            medicationInfo.DrugForm = request.DrugForm;
            medicationInfo.DrugStrength = request.DrugStrength;
            medicationInfo.CreatedDate = DateTime.Now;


            try
            {
               context.PatientMedicationInfo.Add(medicationInfo);
              await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
            var medicationInfos = context.PatientMedicationInfo.ToList();
            return medicationInfos;
        }

        public async Task<IEnumerable<PatientMedicationInfo>> Update(PatientMedicationInfo request)
        {
            try
            {
                var PatientMedicationInfo =await context.PatientMedicationInfo.FirstOrDefaultAsync(X => X.PatientId == request.PatientId);
                if (PatientMedicationInfo == null)
                {
                    return null;
                }
                PatientMedicationInfo.Id = request.Id;
                PatientMedicationInfo.PatientMedicationInfoId = request.PatientMedicationInfoId;
                PatientMedicationInfo.PatientId = request.PatientId;
                PatientMedicationInfo.PhysicianId = request.PhysicianId;
                PatientMedicationInfo.CreatedBy = request.CreatedBy;
                PatientMedicationInfo.DrugId = request.DrugId;
                PatientMedicationInfo.DrugName = request.DrugName;
                PatientMedicationInfo.DrugGenericName = request.DrugGenericName;
                PatientMedicationInfo.DrugBrandName = request.DrugBrandName;
                PatientMedicationInfo.DrugForm = request.DrugForm;
                PatientMedicationInfo.DrugStrength = request.DrugStrength;


                context.Entry(PatientMedicationInfo).State = EntityState.Modified;
              await  context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var medicationInfos =await context.PatientMedicationInfo.ToListAsync();
            return medicationInfos;
        }

     
    }
}
