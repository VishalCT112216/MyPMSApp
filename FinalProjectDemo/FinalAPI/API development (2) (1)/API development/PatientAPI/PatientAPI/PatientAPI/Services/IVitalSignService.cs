using PatientAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Services
{
    public interface IVitalSignService
    {
        Task<IEnumerable<PatientVitalSignInfo>> GetByUserId(int user_Id);
        Task<IEnumerable<PatientVitalSignInfo>> Create(PatientVitalSignInfo request);
        Task<IEnumerable<PatientVitalSignInfo>> Update(PatientVitalSignInfo request);

    }
}
