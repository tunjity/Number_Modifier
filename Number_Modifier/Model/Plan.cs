using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Plan
    {
        public Plan()
        {
            LoanRepayHistories = new HashSet<LoanRepayHistory>();
            LoanRepaySchedules = new HashSet<LoanRepaySchedule>();
        }

        public int Id { get; set; }
        public string? PlanTitle { get; set; }
        public string VoiceMinutes { get; set; } = null!;
        public string SmsQty { get; set; } = null!;
        public string DataQty { get; set; } = null!;
        public int TelcoId { get; set; }
        public float MonthlyCostTotal { get; set; }
        public float MonthlyCost2telco { get; set; }
        public float MonthlyCost2lender { get; set; }
        public float MonthlyCost4others { get; set; }
        public float Downpayment { get; set; }
        public string Duration { get; set; } = null!;
        public string? OtherBenefits { get; set; }
        public float? TelcoCommissionAndTaxes { get; set; }

        public virtual Telco Telco { get; set; } = null!;
        public virtual ICollection<LoanRepayHistory> LoanRepayHistories { get; set; }
        public virtual ICollection<LoanRepaySchedule> LoanRepaySchedules { get; set; }
    }
}
