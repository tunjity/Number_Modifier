using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class UserRoleMap
    {
        public int Id { get; set; }
        public string Section { get; set; } = null!;
        public string Action { get; set; } = null!;
        public bool Superadmin { get; set; }
        public bool Salesexec1 { get; set; }
        public bool Salessuper { get; set; }
        public bool Internalexec1 { get; set; }
        public bool Externalexec1 { get; set; }
        public bool Customerserv1 { get; set; }
        public bool Inventorymgr1 { get; set; }
        public bool Customerserv2 { get; set; }
        public bool Special1sa { get; set; }
        public bool Special2bi { get; set; }
        public bool External2mno { get; set; }
        public bool External2oem { get; set; }
        public bool External2lender { get; set; }
        public bool External2distro { get; set; }
    }
}
