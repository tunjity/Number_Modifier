using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class CustomersAutoRenewal
    {
        public int Id { get; set; }
        public string Msisdn { get; set; } = null!;
        public int Tenure { get; set; }
        public DateTime ActivationDate { get; set; }
    }
}
