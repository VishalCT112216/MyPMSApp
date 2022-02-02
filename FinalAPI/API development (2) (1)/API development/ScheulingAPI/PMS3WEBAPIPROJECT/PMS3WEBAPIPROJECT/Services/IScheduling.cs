using PMS3WEBAPIPROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS3WEBAPIPROJECT.Services
{
  public  interface IScheduling
    {
        IEnumerable<Scheduling> getallschedule();
        IEnumerable<Scheduling> GetByAppointment(int RoleId);

        IEnumerable<Scheduling> GetByPhysicianAppointment(int patientId);
        Scheduling GetById(int id);
        Scheduling GetByUserId(int id);
        IEnumerable<Scheduling> Create(Scheduling request);
        IEnumerable<Scheduling> Update(Scheduling request);

        IEnumerable<Scheduling> Delete(int id);
    }
}
