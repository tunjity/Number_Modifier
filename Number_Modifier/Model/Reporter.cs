using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Reporter
    {
        public int Id { get; set; }
        public string Namespace { get; set; } = null!;
        public bool? Active { get; set; }
        public bool? ReviewDaily { get; set; }
        public bool? ReviewWeekly { get; set; }
        public bool? ReviewMonthly { get; set; }
        public string Emails { get; set; } = null!;
        public string AllstepsDaily { get; set; } = null!;
        public string AllstepsWeekly { get; set; } = null!;
        public string AllstepsMonthly { get; set; } = null!;
        public string? Content { get; set; }
    }
}
