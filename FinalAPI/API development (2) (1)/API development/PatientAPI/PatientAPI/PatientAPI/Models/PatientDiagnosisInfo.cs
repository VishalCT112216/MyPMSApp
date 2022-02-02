using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PatientAPI.Models
{
    public partial class PatientDiagnosisInfo
    {
        public int? Id { get; set; }
        public int PatientDiagnosisInfoId { get; set; }
        public string DiagnosisCode { get; set; }
        public string DiagnosisDescription { get; set; }
        public string DiagnosisIsDepricated { get; set; }
        public int? PatientId { get; set; }
        public int? PhysicianId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Login CreatedByNavigation { get; set; }
        public virtual Login Patient { get; set; }
        public virtual Login Physician { get; set; }
    }
}
