using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Cluster
    {
        public Cluster()
        {
            RetailStores = new HashSet<RetailStore>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateCreated { get; set; }
        public int? SubRegionId { get; set; }
        public int? UserId { get; set; }

        public virtual Subregion? SubRegion { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<RetailStore> RetailStores { get; set; }
    }
}
