using PatientAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Services
{
    public interface IPatientDemographicInformationService
    {
        Task<PatientDemoInfo> GetByUserId(int User_Id);
        Task<IEnumerable<PatientDemoInfo>> Create(PatientDemoInfo request);
        Task<IEnumerable<PatientDemoInfo>> Update(PatientDemoInfo request);

        Task<IEnumerable<PatientDemoInfo>> GetAllPatientDemoInfo();
    }
}
