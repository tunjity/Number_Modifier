using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Workflowapprovalgroup
    {
        public Workflowapprovalgroup()
        {
            Workflowapprovalusergroups = new HashSet<Workflowapprovalusergroup>();
        }

        public int Id { get; set; }
        public string? GroupName { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }

        public virtual ICollection<Workflowapprovalusergroup> Workflowapprovalusergroups { get; set; }
    }
}
