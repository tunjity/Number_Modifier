using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Paelytcustomerlog
    {
        public long Id { get; set; }
        public string? Device { get; set; }
        public string? DeviceBrand { get; set; }
        public string? DevicePlanName { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerPhoneNo { get; set; }
        public string? LoanCode { get; set; }
        public string? Bvn { get; set; }
        public string? Nin { get; set; }
        public string? DeliveryCode { get; set; }
        public string? ReferenceId { get; set; }
        public int LoanTenure { get; set; }
        public string? AccountNumber { get; set; }
        public string? BankCode { get; set; }
        public int StoreId { get; set; }
        public string? ApplicationDate { get; set; }
        public string? DeviceOptionId { get; set; }
        public string? DeviceTypeId { get; set; }
        public long PreCustomerId { get; set; }
        public decimal? Amount { get; set; }
        public string? Imei { get; set; }
        public string? Network { get; set; }
    }
}
