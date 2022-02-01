using Microsoft.EntityFrameworkCore;
using PatientAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Services
{
    public class PatientDemographicInformationService : IPatientDemographicInformationService
    {
        private PMSContext context;
        public PatientDemographicInformationService()
        {
            context = new PMSContext();
        }

        public async Task<IEnumerable<PatientDemoInfo>> Create(PatientDemoInfo request)
        {
            PatientDemoInfo demoInfo = new PatientDemoInfo();
            demoInfo.Id = request.Id;
            demoInfo.UserId = request.UserId;
            demoInfo.Title = request.Title;
            demoInfo.Fname = request.Fname;
            demoInfo.Lname = request.Lname;
            demoInfo.Dob = request.Dob;
            demoInfo.Age = request.Age;
            demoInfo.Race = request.Race;
            demoInfo.Ethinicity = request.Ethinicity;
            demoInfo.LanguagesKnown = request.LanguagesKnown;
            demoInfo.Email = request.Email;
            demoInfo.Gender = request.Gender;
            demoInfo.HomeAddress = request.HomeAddress;
            demoInfo.ContactNumber = request.ContactNumber;
            demoInfo.EmergencyFname = request.EmergencyFname;
            demoInfo.EmergencyLname = request.EmergencyLname;
            demoInfo.Relationship = request.Relationship;
            demoInfo.EmergencyEmail = request.EmergencyEmail;
            demoInfo.EmergencyMobileNo = request.EmergencyMobileNo;
            demoInfo.EmergencyAddress = request.EmergencyAddress;
            demoInfo.Portalaccess = request.Portalaccess;
            demoInfo.TypeofAllergies = request.TypeofAllergies;
            demoInfo.CreatedDate = request.CreatedDate;

            try
            {
                context.PatientDemoInfo.Add(demoInfo);
               await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
            var patientDemoInfo =await context.PatientDemoInfo.ToListAsync();
            return patientDemoInfo;
        }

        public async Task<PatientDemoInfo> GetByUserId(int userId)
        {
            try
            {
                var patientDemoInfo =await context.PatientDemoInfo.FirstOrDefaultAsync(X => X.UserId == userId);
                if (patientDemoInfo == null)
                {
                    return null;
                }
                else
                {
                    return patientDemoInfo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<PatientDemoInfo>> Update(PatientDemoInfo request)
        {
            try
            {
                var patientDemoInfo =await context.PatientDemoInfo.FirstOrDefaultAsync(X => X.UserId == request.UserId);
                if (patientDemoInfo == null)
                {
                    return null;
                }
                patientDemoInfo.Id = request.Id;
                patientDemoInfo.UserId = request.UserId;
                patientDemoInfo.Title = request.Title;
                patientDemoInfo.Fname = request.Fname;
                patientDemoInfo.Lname = request.Lname;
                patientDemoInfo.Dob = request.Dob;
                patientDemoInfo.Age = request.Age;
                patientDemoInfo.Race = request.Race;
                patientDemoInfo.Ethinicity = request.Ethinicity;
                patientDemoInfo.LanguagesKnown = request.LanguagesKnown;
                patientDemoInfo.Email = request.Email;
                patientDemoInfo.Gender = request.Gender;
                patientDemoInfo.HomeAddress = request.HomeAddress;
                patientDemoInfo.ContactNumber = request.ContactNumber;
                patientDemoInfo.EmergencyFname = request.EmergencyFname;
                patientDemoInfo.EmergencyLname = request.EmergencyLname;
                patientDemoInfo.Relationship = request.Relationship;
                patientDemoInfo.EmergencyEmail = request.EmergencyEmail;
                patientDemoInfo.EmergencyMobileNo = request.EmergencyMobileNo;
                patientDemoInfo.EmergencyAddress = request.EmergencyAddress;
                patientDemoInfo.Portalaccess = request.Portalaccess;
                patientDemoInfo.TypeofAllergies = request.TypeofAllergies;
                patientDemoInfo.CreatedDate = DateTime.Now;

                context.Entry(patientDemoInfo).State = EntityState.Modified;
               await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var demoInfos =await context.PatientDemoInfo.ToListAsync();
            return demoInfos;
        }

        public async Task<IEnumerable<PatientDemoInfo>> GetAllPatientDemoInfo()
        {
            try
            {
                var demoInfos =await context.PatientDemoInfo.ToListAsync();
                if (demoInfos.Count == 0)
                {
                    return null;
                }
                return demoInfos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
