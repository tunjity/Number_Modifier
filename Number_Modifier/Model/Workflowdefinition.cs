using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Workflowdefinition
    {
        public Workflowdefinition()
        {
            Deviceworkflows = new HashSet<Deviceworkflow>();
            Workflowstepdefinitions = new HashSet<Workflowstepdefinition>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }

        public virtual ICollection<Deviceworkflow> Deviceworkflows { get; set; }
        public virtual ICollection<Workflowstepdefinition> Workflowstepdefinitions { get; set; }
    }
}
