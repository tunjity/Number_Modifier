using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Ptmfbtransactionslog
    {
        public int Id { get; set; }
        public string? RetrievalReference { get; set; }
        public string? TransactionType { get; set; }
        public string? Amount { get; set; }
        public string? Status { get; set; }
        public DateTime Created { get; set; }
        public bool IsMostRecent { get; set; }
        public DateTime Modified { get; set; }
        public string? TransactionRef { get; set; }
    }
}
