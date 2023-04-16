using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Scheduledreport
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? ReportCode { get; set; }
        public string? Reciever { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string? CopyRecipient { get; set; }
        public bool IsActive { get; set; }
        public string? ReportMode { get; set; }
    }
}
