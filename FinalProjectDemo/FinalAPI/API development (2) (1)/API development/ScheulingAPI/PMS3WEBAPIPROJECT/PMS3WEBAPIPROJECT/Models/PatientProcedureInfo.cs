using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PMS3WEBAPIPROJECT.Models
{
    public partial class PatientProcedureInfo
    {
        public int? Id { get; set; }
        public int PatientProcedureInfoId { get; set; }
        public string ProcedureCode { get; set; }
        public int? PatientId { get; set; }
        public int? PhysicianId { get; set; }
        public int? CreatedBy { get; set; }
        public string ProcedureIsDepricated { get; set; }
        public string ProcedureDescription { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Login CreatedByNavigation { get; set; }
        public virtual Login Patient { get; set; }
    }
}
