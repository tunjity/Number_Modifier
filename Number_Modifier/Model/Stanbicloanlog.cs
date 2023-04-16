using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Stanbicloanlog
    {
        public int Id { get; set; }
        public string? Mssidn { get; set; }
        public decimal LoanRequestAmount { get; set; }
        public DateTime RequestTimestamp { get; set; }
        public decimal? LoanApprovedAmount { get; set; }
        public decimal? LoanAvailableAmount { get; set; }
        public string? LoanAccountNo { get; set; }
        public DateTime? WebhookResponseTimestamp { get; set; }
        public int SalesRepId { get; set; }
        public string? RefNo { get; set; }
    }
}
