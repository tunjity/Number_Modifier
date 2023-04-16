using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class TelcoBundle
    {
        public int Id { get; set; }
        public string BundleName { get; set; } = null!;
        public int TelcoId { get; set; }
        public short TenureMonths { get; set; }
        public string? TelcoBundleCode { get; set; }
    }
}
