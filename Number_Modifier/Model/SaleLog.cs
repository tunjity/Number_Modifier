using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class SaleLog
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string ReceiptUrl { get; set; } = null!;
        public int RepId { get; set; }
        public int DeviceId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int PlanId { get; set; }
        public int LoanId { get; set; }
        public decimal? Commission { get; set; }
    }
}
