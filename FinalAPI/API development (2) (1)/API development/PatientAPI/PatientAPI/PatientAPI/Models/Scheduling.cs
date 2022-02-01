using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PatientAPI.Models
{
    public partial class Scheduling
    {
        public int SchedulingId { get; set; }
        public string MeetingTitle { get; set; }
        public string DescriptiveInformation { get; set; }
        public DateTime? DateOfAppointment { get; set; }
        public string TimeOfAppointment { get; set; }
        public int? PatientId { get; set; }
        public int? PhysicianId { get; set; }
        public int? CreatedBy { get; set; }

        public virtual Login CreatedByNavigation { get; set; }
        public virtual Login Patient { get; set; }
        public virtual Login Physician { get; set; }
    }
}
