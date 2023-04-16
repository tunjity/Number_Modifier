using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Deviceworkflowstephistory
    {
        public int Id { get; set; }
        public int? DeviceWorkFlowId { get; set; }
        public int? WorkFlowStepDefinitionId { get; set; }
        public string? Status { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }

        public virtual Deviceworkflow? DeviceWorkFlow { get; set; }
        public virtual Workflowstepdefinition? WorkFlowStepDefinition { get; set; }
    }
}
