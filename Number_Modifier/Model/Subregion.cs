using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Subregion
    {
        public Subregion()
        {
            Clusters = new HashSet<Cluster>();
            RetailStores = new HashSet<RetailStore>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? RegionId { get; set; }
        public DateTime Created { get; set; }
        public int? UserId { get; set; }

        public virtual Region? Region { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Cluster> Clusters { get; set; }
        public virtual ICollection<RetailStore> RetailStores { get; set; }
    }
}
