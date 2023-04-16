using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class EnterpriseBundle
    {
        public EnterpriseBundle()
        {
            EnterpriseBundlePlans = new HashSet<EnterpriseBundlePlan>();
        }

        public int Id { get; set; }
        public string BundleName { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int DeviceRangeId { get; set; }

        public virtual ICollection<EnterpriseBundlePlan> EnterpriseBundlePlans { get; set; }
    }
}
