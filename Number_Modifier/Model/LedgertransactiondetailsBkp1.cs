using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class LedgertransactiondetailsBkp1
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
    }
}
