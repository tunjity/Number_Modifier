using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class LenderCreditLimit
    {
        public int Id { get; set; }
        public int LenderId { get; set; }
        public string RiskClass { get; set; } = null!;
        public float CreditLimit { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
