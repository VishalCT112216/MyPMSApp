using PatientAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Services
{
    public interface IProcedureService
    {
        Task<IEnumerable<ProcedureData>> GetAllProceduresFromMaster();
        Task<IEnumerable<ProcedureData>> CreateMasterProcedure(ProcedureData request);
        Task<IEnumerable<PatientProcedureInfo>> GetByUserId(int user_Id);
        //Task<PatientProcedureInfo> GetByUserId(int user_Id);
        Task<IEnumerable<PatientProcedureInfo>> Create(PatientProcedureInfo request);
        Task<IEnumerable<PatientProcedureInfo>> Update(PatientProcedureInfo request);

    }
}
