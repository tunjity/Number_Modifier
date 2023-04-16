using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class LoanRepaySchedule
    {
        public int Id { get; set; }
        public int LoanId { get; set; }
        public int PlanId { get; set; }
        public int CustomerId { get; set; }
        public int DeviceId { get; set; }
        public float TotalLoanAmount { get; set; }
        public int LoanAllocationId { get; set; }
        public float AmountPending { get; set; }
        public DateTime ActivationDate { get; set; }
        public float AmountPaid { get; set; }
        public float NextAmountDue { get; set; }
        public string MonthlyAnniversaryDate { get; set; } = null!;
        public short NumberOfRepayments { get; set; }
        public string LoanDuration { get; set; } = null!;
        public short NumberOfPaymentsPending { get; set; }
        public short NumberOfPaymentMade { get; set; }
        public short PenaltyPending { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string? TxDumpsList { get; set; }
        public DateTime? NextPaymentDate { get; set; }
        public short RepayIsDaily { get; set; }
        public short RepayIsWeekly { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Device Device { get; set; } = null!;
        public virtual Loan Loan { get; set; } = null!;
        public virtual Plan Plan { get; set; } = null!;
    }
}
