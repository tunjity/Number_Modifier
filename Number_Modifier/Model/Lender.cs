using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Lender
    {
        public Lender()
        {
            Loans = new HashSet<Loan>();
        }

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public bool Status { get; set; }
        public int LoanCount { get; set; }
        public bool AutoApprove { get; set; }
        public float DailyCreditLimit { get; set; }
        public float MonthlyCreditLimit { get; set; }
        public string? OnboardUrl { get; set; }
        public float? ProcessingFeeRate { get; set; }
        public string? BannerUrl { get; set; }
        public string? Code { get; set; }
        public string? BrandTheme { get; set; }
        public bool IsCustomKyc { get; set; }
        public string? LogoUrl { get; set; }
        public string? ReportReceivers { get; set; }
        public float? ActualMonthlyInterestRate { get; set; }
        public float? EstimatedInterestRate { get; set; }

        public virtual Partner Company { get; set; } = null!;
        public virtual ICollection<Loan> Loans { get; set; }
    }
}
