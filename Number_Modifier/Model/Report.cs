using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Report
    {
        public Report()
        {
            Reportparameters = new HashSet<Reportparameter>();
        }

        public int Id { get; set; }
        public string? ReportCode { get; set; }
        public string? ReportName { get; set; }
        public int ReportType { get; set; }
        public int ReportCategory { get; set; }
        public string? ReportUrl { get; set; }
        public string? ReportPermissionCode { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string? ReportQuery { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Reportparameter> Reportparameters { get; set; }
    }
}
