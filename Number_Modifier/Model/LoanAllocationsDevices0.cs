using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class LoanAllocationsDevices0
    {
        public int Id { get; set; }
        public int LoanId { get; set; }
        public int CustomerId { get; set; }
        public int DeviceId { get; set; }
        public float TotalAmt { get; set; }
        public int RepId { get; set; }
        public int Duration { get; set; }
        public string Status { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
