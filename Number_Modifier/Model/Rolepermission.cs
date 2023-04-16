using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Rolepermission
    {
        public int Id { get; set; }
        public int UserRoleId { get; set; }
        public int PermissionId { get; set; }

        public virtual Permission Permission { get; set; } = null!;
        public virtual UserRole UserRole { get; set; } = null!;
    }
}
