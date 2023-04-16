using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Rechargelist
    {
        public int? UserId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Network { get; set; }
        public long? PhoneNo { get; set; }
        public int IsTreated { get; set; }
        public string Comment { get; set; } = null!;
    }
}
