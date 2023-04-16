using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class PenaltyPayment
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int LoanId { get; set; }
        public float AmountPaid { get; set; }
        public DateTime Created { get; set; }
    }
}
