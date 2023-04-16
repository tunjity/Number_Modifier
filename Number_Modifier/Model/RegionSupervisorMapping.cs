using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class RegionSupervisorMapping
    {
        public int Id { get; set; }
        public int? StateId { get; set; }
        public int? RegionId { get; set; }
        public int? SupervisorId { get; set; }

        public virtual Region? Region { get; set; }
        public virtual State? State { get; set; }
        public virtual User? Supervisor { get; set; }
    }
}
