using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class EnterpriseCompany
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = null!;
        public string CompanyLocation { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
