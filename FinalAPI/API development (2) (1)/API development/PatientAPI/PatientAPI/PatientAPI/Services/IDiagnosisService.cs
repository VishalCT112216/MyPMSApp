using PatientAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Services
{
    public interface IDiagnosisService
    {
        Task<IEnumerable<Diagnosis>> GetAllDiagnosisFromMaster();
        Task<IEnumerable<Diagnosis>> CreateMasterDiagnosis(Diagnosis request);
        Task<IEnumerable<PatientDiagnosisInfo>> GetDiagnosisByUserId(int User_Id);
        Task<IEnumerable<PatientDiagnosisInfo>> Create(PatientDiagnosisInfo request);
        Task<IEnumerable<PatientDiagnosisInfo>> Update(PatientDiagnosisInfo request);
    }
}
