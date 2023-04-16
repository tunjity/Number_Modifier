using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class DeviceSubRenewal
    {
        public int Id { get; set; }
        public string Msisdn { get; set; } = null!;
        public string Imei { get; set; } = null!;
        public float? AmtPaid { get; set; }
        public string? Plan { get; set; }
        public DateTime? AionActivationDt { get; set; }
        public DateTime? AionNextRenewalDt { get; set; }
    }
}
