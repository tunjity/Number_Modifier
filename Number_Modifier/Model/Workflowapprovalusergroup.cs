using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Workflowapprovalusergroup
    {
        public Workflowapprovalusergroup()
        {
            Workflowstepdefinitions = new HashSet<Workflowstepdefinition>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int? ApprovalGroupId { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }

        public virtual Workflowapprovalgroup? ApprovalGroup { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual ICollection<Workflowstepdefinition> Workflowstepdefinitions { get; set; }
    }
}
