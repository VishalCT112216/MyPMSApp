using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InboxAPI.Models
{
    public partial class Login
    {
        public Login()
        {
            PatientDiagnosisInfoCreatedByNavigation = new HashSet<PatientDiagnosisInfo>();
            PatientDiagnosisInfoPatient = new HashSet<PatientDiagnosisInfo>();
            PatientDiagnosisInfoPhysician = new HashSet<PatientDiagnosisInfo>();
            PatientMedicationInfoCreatedByNavigation = new HashSet<PatientMedicationInfo>();
            PatientMedicationInfoPatient = new HashSet<PatientMedicationInfo>();
            PatientMedicationInfoPhysician = new HashSet<PatientMedicationInfo>();
            PatientProcedureInfoCreatedByNavigation = new HashSet<PatientProcedureInfo>();
            PatientProcedureInfoPatient = new HashSet<PatientProcedureInfo>();
            PatientVitalSignInfoCreatedByNavigation = new HashSet<PatientVitalSignInfo>();
            PatientVitalSignInfoPatient = new HashSet<PatientVitalSignInfo>();
            PatientVitalSignInfoPhysician = new HashSet<PatientVitalSignInfo>();
            SchedulingCreatedByNavigation = new HashSet<Scheduling>();
            SchedulingPatient = new HashSet<Scheduling>();
            SchedulingPhysician = new HashSet<Scheduling>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string OldPassword { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string EmailId { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? Doj { get; set; }
        public string ContactNo { get; set; }
        public string Status { get; set; }
        public int? RoleId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? Id { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<PatientDiagnosisInfo> PatientDiagnosisInfoCreatedByNavigation { get; set; }
        public virtual ICollection<PatientDiagnosisInfo> PatientDiagnosisInfoPatient { get; set; }
        public virtual ICollection<PatientDiagnosisInfo> PatientDiagnosisInfoPhysician { get; set; }
        public virtual ICollection<PatientMedicationInfo> PatientMedicationInfoCreatedByNavigation { get; set; }
        public virtual ICollection<PatientMedicationInfo> PatientMedicationInfoPatient { get; set; }
        public virtual ICollection<PatientMedicationInfo> PatientMedicationInfoPhysician { get; set; }
        public virtual ICollection<PatientProcedureInfo> PatientProcedureInfoCreatedByNavigation { get; set; }
        public virtual ICollection<PatientProcedureInfo> PatientProcedureInfoPatient { get; set; }
        public virtual ICollection<PatientVitalSignInfo> PatientVitalSignInfoCreatedByNavigation { get; set; }
        public virtual ICollection<PatientVitalSignInfo> PatientVitalSignInfoPatient { get; set; }
        public virtual ICollection<PatientVitalSignInfo> PatientVitalSignInfoPhysician { get; set; }
        public virtual ICollection<Scheduling> SchedulingCreatedByNavigation { get; set; }
        public virtual ICollection<Scheduling> SchedulingPatient { get; set; }
        public virtual ICollection<Scheduling> SchedulingPhysician { get; set; }
    }
}
