using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class CustomerLockedview
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Acl { get; set; } = null!;
        public string? RoleAcl { get; set; }
        public string? ExclAcl { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
