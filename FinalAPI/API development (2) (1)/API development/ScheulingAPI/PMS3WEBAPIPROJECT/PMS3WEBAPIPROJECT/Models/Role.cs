using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PMS3WEBAPIPROJECT.Models
{
    public partial class Role
    {
        public Role()
        {
            Login = new HashSet<Login>();
        }

        public int? Id { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<Login> Login { get; set; }
    }
}
