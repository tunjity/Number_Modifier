using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Telco
    {
        public Telco()
        {
            Plans = new HashSet<Plan>();
        }

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public bool Status { get; set; }
        public int PlanCount { get; set; }

        public virtual Partner Company { get; set; } = null!;
        public virtual ICollection<Plan> Plans { get; set; }
    }
}
