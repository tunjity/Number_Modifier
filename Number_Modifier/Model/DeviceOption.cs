using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class DeviceOption
    {
        public int Id { get; set; }
        public string RiskClasses { get; set; } = null!;
        public int LoanId { get; set; }
        public int DeviceTypeId { get; set; }
        public short DurationMonths { get; set; }
        public string? BundleName { get; set; }
        public float RefMinAmount { get; set; }
        public double RefMaxAmount { get; set; }
        public short? MaxDurationMonths { get; set; }
        public short? MinDurationMonths { get; set; }
        public float? BundleDeviceCost { get; set; }
        public bool? Status { get; set; }
        public int TelcoBundleId { get; set; }
    }
}
