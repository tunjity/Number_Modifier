using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Paystackrecipient
    {
        public long Id { get; set; }
        public string? RecipientCode { get; set; }
        public string? BankCode { get; set; }
        public string? AccountNo { get; set; }
        public string? AcountName { get; set; }
        public string? Currency { get; set; }
        public string? Description { get; set; }
        public string? RecipientType { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
