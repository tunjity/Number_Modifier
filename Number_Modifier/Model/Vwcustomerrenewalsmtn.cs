using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Vwcustomerrenewalsmtn
    {
        public long Repaymentcount { get; set; }
        public string? Msisdn { get; set; }
        public string? ProductName { get; set; }
        public decimal? ChargingAmount { get; set; }
        public DateTime? MinRenewalDate { get; set; }
        public DateTime? MaxRenewalDate { get; set; }
    }
}
