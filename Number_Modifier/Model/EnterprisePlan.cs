using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class EnterprisePlan
    {
        public EnterprisePlan()
        {
            EnterpriseBundlePlans = new HashSet<EnterpriseBundlePlan>();
        }

        public int Id { get; set; }
        public string PlanName { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual ICollection<EnterpriseBundlePlan> EnterpriseBundlePlans { get; set; }
    }
}
