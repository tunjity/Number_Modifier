using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class VtuPlan
    {
        public int Id { get; set; }
        public string VoiceMinutes { get; set; } = null!;
        public string SmsQty { get; set; } = null!;
        public string DataQty { get; set; } = null!;
        public int TelcoId { get; set; }
        public string Country { get; set; } = null!;
        public int CurrencyId { get; set; }
        public float TotalAmt { get; set; }
        public int Duration { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
