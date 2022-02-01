using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InboxAPI.Models
{
    public partial class PatientDemoInfo
    {
        public int? Id { get; set; }
        public int PatientDemoInfoId { get; set; }
        public int? UserId { get; set; }
        public string Title { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime? Dob { get; set; }
        public string Age { get; set; }
        public string Race { get; set; }
        public string Ethinicity { get; set; }
        public string LanguagesKnown { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string HomeAddress { get; set; }
        public string ContactNumber { get; set; }
        public string EmergencyFname { get; set; }
        public string EmergencyLname { get; set; }
        public string Relationship { get; set; }
        public string EmergencyEmail { get; set; }
        public string EmergencyMobileNo { get; set; }
        public string EmergencyAddress { get; set; }
        public string Portalaccess { get; set; }
        public string TypeofAllergies { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
