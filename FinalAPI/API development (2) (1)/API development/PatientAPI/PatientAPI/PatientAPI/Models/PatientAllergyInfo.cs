using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PatientAPI.Models
{
    public partial class PatientAllergyInfo
    {
        public int? Id { get; set; }
        public int PatientAllergyInfoId { get; set; }
        public int? UserId { get; set; }
        public bool? HasAllergy { get; set; }
        public string AllergyId { get; set; }
        public string AllergyType { get; set; }
        public string AllergyName { get; set; }
        public string ClinicalInfo { get; set; }
        public string AllergyDescription { get; set; }
        public string IsFatal { get; set; }
    }
}
