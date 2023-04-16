using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class EnterpriseCustomer
    {
        public int Id { get; set; }
        public string Msisdn { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Status { get; set; } = null!;
        public decimal CreditLimit { get; set; }
        public int CompanyId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public ulong? FinancierCompanyId { get; set; }
    }
}
