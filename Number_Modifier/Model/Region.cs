using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Region
    {
        public Region()
        {
            RegionSupervisorMappings = new HashSet<RegionSupervisorMapping>();
            RetailStores = new HashSet<RetailStore>();
            Subregions = new HashSet<Subregion>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int SupervisorId { get; set; }

        public virtual ICollection<RegionSupervisorMapping> RegionSupervisorMappings { get; set; }
        public virtual ICollection<RetailStore> RetailStores { get; set; }
        public virtual ICollection<Subregion> Subregions { get; set; }
    }
}
