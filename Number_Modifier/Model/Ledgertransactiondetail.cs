using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Ledgertransactiondetail
    {
        public long Id { get; set; }
        public int LedgerId { get; set; }
        public long LedgerTransactionId { get; set; }
        public decimal ProposedAmount { get; set; }
        public decimal ActualAmount { get; set; }
        public decimal NetAmount { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Ledger Ledger { get; set; } = null!;
        public virtual Ledgertransaction LedgerTransaction { get; set; } = null!;
    }
}
