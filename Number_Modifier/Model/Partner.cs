using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Partner
    {
        public Partner()
        {
            RetailStores = new HashSet<RetailStore>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; } = null!;
        public string CacRegNo { get; set; } = null!;
        public string? Address { get; set; }
        public string? Contact1Name { get; set; }
        public string? Contact1Phone { get; set; }
        public string? Contact1Email { get; set; }
        public string? Contact2Name { get; set; }
        public string? Contact2Phone { get; set; }
        public string? Contact2Email { get; set; }
        public string CompanyType { get; set; } = null!;
        public string? BankName { get; set; }
        public string? BankAcc { get; set; }
        public string? BankAccName { get; set; }

        public virtual Distributor? Distributor { get; set; }
        public virtual Lender? Lender { get; set; }
        public virtual Telco? Telco { get; set; }
        public virtual ICollection<RetailStore> RetailStores { get; set; }
    }
}
