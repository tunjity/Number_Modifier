using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class RoleAcl
    {
        public int Id { get; set; }
        public string Role { get; set; } = null!;
        public string Ctrl { get; set; } = null!;
        public string CtrlMethod { get; set; } = null!;
        public bool CanView { get; set; }
        public bool CanAdd { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
