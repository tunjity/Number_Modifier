using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class MtnRenewReport
    {
        public int Id { get; set; }
        public string Msisdn { get; set; } = null!;
        public string? ChargingAmt { get; set; }
        public string? Customer { get; set; }
        public string? Device { get; set; }
        public string? Imei { get; set; }
        public string? Plan { get; set; }
        public string? CurrentLoan { get; set; }
        public string? LastLoan { get; set; }
        public float? LastPaidAmt { get; set; }
        public DateTime? AionLastRenewalDate { get; set; }
        public DateTime? AionNextRenewalDate { get; set; }
        public DateTime? SysLastRenewalDate { get; set; }
        public DateTime? SysNextRenewalDate { get; set; }
        public string? IsUnlock { get; set; }
    }
}
