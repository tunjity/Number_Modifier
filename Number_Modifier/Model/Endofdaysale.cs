using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Endofdaysale
    {
        public long Id { get; set; }
        public DateTime? Date { get; set; }
        public string? Device { get; set; }
        public string? Imei { get; set; }
        public string? Msisdn { get; set; }
        public string? Customer { get; set; }
        public string? Financier { get; set; }
        public string? LoanDuration { get; set; }
        public string? Telco { get; set; }
        public string? PlanTitle { get; set; }
        public string? Retailer { get; set; }
        public string? RepName { get; set; }
        public decimal? LoanAmount { get; set; }
        public string? AccountNo { get; set; }
        public string? KycUrl { get; set; }
    }
}
