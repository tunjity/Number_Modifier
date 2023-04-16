using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Subloan
    {
        public int Id { get; set; }
        public int LoanId { get; set; }
        public float? Shareamt { get; set; }
        public float? InterestAmt { get; set; }
        public string? FinancierCode { get; set; }
        public int FinancierId { get; set; }
    }
}
