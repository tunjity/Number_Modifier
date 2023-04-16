using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class UserLockedview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Acl { get; set; } = null!;
        public string? RoleAcl { get; set; }
        public string? ExclAcl { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
