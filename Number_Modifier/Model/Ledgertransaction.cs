using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Ledgertransaction
    {
        public Ledgertransaction()
        {
            Ledgertransactiondetails = new HashSet<Ledgertransactiondetail>();
        }

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
        public int? StoreId { get; set; }
        public string? BundledDeviceTypeId { get; set; }
        public decimal? Downpayment { get; set; }
        public string? Imei { get; set; }
        public string? RepId { get; set; }
        public string? UpdatedStoreId { get; set; }
        public decimal? VoluntaryDownpayment { get; set; }
        public string? OldFinancierCode { get; set; }
        public bool? IsCancelled { get; set; }
        public DateTime? BookedLoanDate { get; set; }
        public DateTime? RetailerPaidDate { get; set; }

        public virtual ICollection<Ledgertransactiondetail> Ledgertransactiondetails { get; set; }
    }
}
