using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Bankstatement
    {
        public long Id { get; set; }
        public long PreCustomerId { get; set; }
        public string? FinancierCode { get; set; }
        public string? BankName { get; set; }
        public string? AccountNo { get; set; }
        public string? AccountName { get; set; }
        public decimal Amount { get; set; }
        public string? Narration { get; set; }
        public string? TxnRefId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
