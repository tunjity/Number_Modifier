using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Paymentinitiationlog
    {
        public string RefNo { get; set; } = null!;
        public string? Amount { get; set; }
        public string? Description { get; set; }
        public bool? IsComplete { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
