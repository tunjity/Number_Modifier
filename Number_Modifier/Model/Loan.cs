using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Loan
    {
        public Loan()
        {
            LoanRepayHistories = new HashSet<LoanRepayHistory>();
            LoanRepaySchedules = new HashSet<LoanRepaySchedule>();
        }

        public int Id { get; set; }
        public string? LoanTitle { get; set; }
        public int LenderId { get; set; }
        public float MinimumScore { get; set; }
        public string? MinRiskClass { get; set; }
        public string? MaxRiskClass { get; set; }
        public int PlanId { get; set; }
        public string MonthlyTenure { get; set; } = null!;
        public float? Downpayment { get; set; }
        public float PrincipalAmt { get; set; }
        public float InterestAmt { get; set; }
        public string TotalAmt { get; set; } = null!;
        public float? PenaltyAmt { get; set; }
        public float? IntlgrAmt { get; set; }
        public float? TelcoAmt { get; set; }
        public int? GraceTimeDays { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string? PaelytLoancode { get; set; }
        public float? InterestAmt2Lender { get; set; }
        public float? InterestAmt2Intlgr { get; set; }
        public float? OriginInterestFees { get; set; }
        public float? AftersalesFees { get; set; }
        public float? MnoCommission { get; set; }
        public float? InterestRate { get; set; }
        public bool? IsCofinance { get; set; }
        public int? SecondaryFinancierId { get; set; }
        public float? SecondaryFinancierInterestAmt { get; set; }
        public float? SecondaryFinancierShareamt { get; set; }
        public int? TertiaryFinancierId { get; set; }
        public float? TertiaryFinancierInterestAmt { get; set; }
        public float? TertiaryFinancierShareamt { get; set; }

        public virtual Lender Lender { get; set; } = null!;
        public virtual ICollection<LoanRepayHistory> LoanRepayHistories { get; set; }
        public virtual ICollection<LoanRepaySchedule> LoanRepaySchedules { get; set; }
    }
}
