using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Distributor
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public bool Status { get; set; }

        public virtual Partner Company { get; set; } = null!;
    }
}
