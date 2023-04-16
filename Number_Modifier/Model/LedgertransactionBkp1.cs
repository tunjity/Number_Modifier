using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class LedgertransactionBkp1
    {
        public long Id { get; set; }
        public int PreCustomerId { get; set; }
        public string? RefNo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool? IsComplete { get; set; }
        public string? SystemComment { get; set; }
        public string? UserComment { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int? DeviceOptionId { get; set; }
        public string? FinancierCode { get; set; }
        public string? LoanAccountNo { get; set; }
        public int? SalesRepId { get; set; }
        public int? DeviceTypeId { get; set; }
        public decimal? DownPayt { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? MonthlyRepayt { get; set; }
        public bool? IsMoved { get; set; }
        public bool? IsCoFinanced { get; set; }
    }
}
