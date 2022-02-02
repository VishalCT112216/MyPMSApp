using PatientAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Services
{
    public interface IAllergyService
    {
        Task<IEnumerable<Allergy>> GetAllAllergiesFromMaster();
        Task<IEnumerable<Allergy>> CreateMasterAllery(Allergy request);
        Task<PatientAllergyInfo> GetByUserId(int user_Id);

       
        Task<IEnumerable<PatientAllergyInfo>> Create(PatientAllergyInfo request);
    }
}
