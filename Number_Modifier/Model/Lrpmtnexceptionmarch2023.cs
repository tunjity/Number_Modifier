using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Lrpmtnexceptionmarch2023
    {
        public int Id { get; set; }
        public int LoanId { get; set; }
        public int PlanId { get; set; }
        public int CustomerId { get; set; }
        public int DeviceId { get; set; }
        public DateTime MonthlyActivationDate { get; set; }
        public float AmtPaid { get; set; }
        public float? PenaltyAmt { get; set; }
        public DateTime ActualPaymentDate { get; set; }
        public int DataDumpId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
