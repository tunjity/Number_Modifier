using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Workflowstepdefinition
    {
        public Workflowstepdefinition()
        {
            Deviceworkflowstephistories = new HashSet<Deviceworkflowstephistory>();
        }

        public int Id { get; set; }
        public int? WorkFlowDefinitionId { get; set; }
        public string? StepName { get; set; }
        public int? ApprovalUserGroupId { get; set; }
        public int NextStepId { get; set; }
        public bool IsFirst { get; set; }
        public bool IsLast { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }

        public virtual Workflowapprovalusergroup? ApprovalUserGroup { get; set; }
        public virtual Workflowdefinition? WorkFlowDefinition { get; set; }
        public virtual ICollection<Deviceworkflowstephistory> Deviceworkflowstephistories { get; set; }
    }
}
