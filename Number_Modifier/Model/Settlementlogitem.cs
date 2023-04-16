using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Settlementlogitem
    {
        public long Id { get; set; }
        public long SettlementLogId { get; set; }
        public string? MssIdn { get; set; }
        public DateTime RepayDate { get; set; }
        public string? Financier { get; set; }
        public float AmountRepay { get; set; }
        public string? LoanAccountNo { get; set; }
        public float FinancierAmount { get; set; }

        public virtual Settlementlog SettlementLog { get; set; } = null!;
    }
}
