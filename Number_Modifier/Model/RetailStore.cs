using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class RetailStore
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string StoreName { get; set; } = null!;
        public string StoreAddress { get; set; } = null!;
        public string LocationLong { get; set; } = null!;
        public string LocationLat { get; set; } = null!;
        public int? Countrycode { get; set; }
        public int RepCount { get; set; }
        public int LgaId { get; set; }
        public int StateId { get; set; }
        public string ContactName { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public string ContactEmail { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string BankAcc { get; set; } = null!;
        public string BankAccName { get; set; } = null!;
        public float CommissionRate { get; set; }
        public string? Otp { get; set; }
        public string? Password { get; set; }
        public string? Username { get; set; }
        public string? Category { get; set; }
        public string? DistributorCode { get; set; }
        public bool? IsActive { get; set; }
        public string? Role { get; set; }
        public int? ClustersId { get; set; }
        public int? RegionId { get; set; }
        public int? SubRegionId { get; set; }

        public virtual Cluster? Clusters { get; set; }
        public virtual Partner Company { get; set; } = null!;
        public virtual Region? Region { get; set; }
        public virtual Subregion? SubRegion { get; set; }
    }
}
