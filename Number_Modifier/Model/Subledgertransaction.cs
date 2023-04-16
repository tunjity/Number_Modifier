using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Subledgertransaction
    {
        public int Id { get; set; }
        public int LedgerTransactionId { get; set; }
        public string? RefNo { get; set; }
        public string? LoanAccountNo { get; set; }
        public string? FinancierCode { get; set; }
        public int FinancierId { get; set; }
        public bool? IsComplete { get; set; }
        public decimal LoanAmount { get; set; }
        public string? SystemComment { get; set; }
    }
}
