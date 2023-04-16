using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Vwrepaymenthistorydetail
    {
        public long Historycount { get; set; }
        public int CustomerId { get; set; }
        public DateTime? ActivationDate { get; set; }
        public DateTime? MinExtensionDate { get; set; }
        public DateTime? MaxRenewalDate { get; set; }
        public DateTime? MaxExtensionDate { get; set; }
        public float? AmtPaid { get; set; }
    }
}
