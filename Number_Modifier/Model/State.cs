using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class State
    {
        public State()
        {
            RegionSupervisorMappings = new HashSet<RegionSupervisorMapping>();
        }

        public int Id { get; set; }
        public string StateName { get; set; } = null!;
        public int? RegionId { get; set; }

        public virtual ICollection<RegionSupervisorMapping> RegionSupervisorMappings { get; set; }
    }
}
