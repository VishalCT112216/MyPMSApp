using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InboxAPI.Models
{
    public partial class PatientMedicationInfo
    {
        public int? Id { get; set; }
        public int PatientMedicationInfoId { get; set; }
        public string DrugId { get; set; }
        public string DrugName { get; set; }
        public string DrugGenericName { get; set; }
        public string DrugBrandName { get; set; }
        public string DrugForm { get; set; }
        public string DrugStrength { get; set; }
        public int? PatientId { get; set; }
        public int? PhysicianId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Login CreatedByNavigation { get; set; }
        public virtual Login Patient { get; set; }
        public virtual Login Physician { get; set; }
    }
}
