using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Deviceworkflow
    {
        public Deviceworkflow()
        {
            Deviceworkflowstephistories = new HashSet<Deviceworkflowstephistory>();
        }

        public int Id { get; set; }
        public int? WorkFlowDefinitionId { get; set; }
        public int? RepId { get; set; }
        public int? DeviceId { get; set; }
        public decimal OldDevicePrice { get; set; }
        public decimal NewDevicePrice { get; set; }
        public string? Reason { get; set; }
        public string? Status { get; set; }
        public string? ProcessLevel { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
        public int? RetailStoreId { get; set; }

        public virtual Device? Device { get; set; }
        public virtual User? Rep { get; set; }
        public virtual Workflowdefinition? WorkFlowDefinition { get; set; }
        public virtual ICollection<Deviceworkflowstephistory> Deviceworkflowstephistories { get; set; }
    }
}
