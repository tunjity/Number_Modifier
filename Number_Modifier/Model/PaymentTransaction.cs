using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class PaymentTransaction
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string TransactionRef { get; set; } = null!;
        public double Amount { get; set; }
        public double Commission { get; set; }
        public int CurrencyId { get; set; }
        public string Status { get; set; } = null!;
        public string StatusCode { get; set; } = null!;
        public string PayGateway { get; set; } = null!;
        public string TransactionType { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string? Comment1 { get; set; }
        public string? Comment2 { get; set; }
        public string? Comment3 { get; set; }
        public string? IpAddress { get; set; }
    }
}
