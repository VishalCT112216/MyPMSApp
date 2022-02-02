using PatientAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Services
{
    public interface IDrugService
    {
        Task<IEnumerable<Drug>> GetAllDrugsFromMaster();
        Task<IEnumerable<Drug>> CreateMasterDrug(Drug request);
        Task<IEnumerable<PatientMedicationInfo>> GetMedicationByUserId(int User_Id);

        //Task<PatientMedicationInfo> GetMedicationByUserId(int User_Id);
        Task<IEnumerable<PatientMedicationInfo>> Create(PatientMedicationInfo request);
        Task<IEnumerable<PatientMedicationInfo>> Update(PatientMedicationInfo request);
    }
}
