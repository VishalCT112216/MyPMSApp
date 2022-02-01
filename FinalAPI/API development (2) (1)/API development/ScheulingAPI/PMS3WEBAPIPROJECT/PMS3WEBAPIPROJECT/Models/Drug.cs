using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PMS3WEBAPIPROJECT.Models
{
    public partial class Drug
    {
        public string DrugId { get; set; }
        public string DrugName { get; set; }
        public string DrugGenericName { get; set; }
        public string DrugBrandName { get; set; }
        public string DrugForm { get; set; }
        public string DrugStrength { get; set; }
        public int Id { get; set; }
    }
}
