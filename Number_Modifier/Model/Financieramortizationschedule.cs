using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Financieramortizationschedule
    {
        public int Id { get; set; }
        public int? FinancierId { get; set; }
        public string? FinancierCode { get; set; }
        public string? Bundle { get; set; }
        public int? RepaymentMonth { get; set; }
        public decimal? PrincipalRepayment { get; set; }
        public decimal? InterestRepayment { get; set; }
        public decimal? OriginatingFee { get; set; }
        public decimal? TotalPaymentToFinancier { get; set; }
        public decimal? TelcoFee { get; set; }
        public decimal? PlatformFee { get; set; }
        public decimal? TotalMonthlyRepayment { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
