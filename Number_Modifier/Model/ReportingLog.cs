using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class ReportingLog
    {
        public int Id { get; set; }
        public string Namespace { get; set; } = null!;
        public string Completed { get; set; } = null!;
        public string Steps { get; set; } = null!;
        public string StepsDone { get; set; } = null!;
        public string Content { get; set; } = null!;
        public bool SentStatus { get; set; }
        public DateTime SentOn { get; set; }
        public DateTime ProcessStart { get; set; }
        public DateTime ProcessEnd { get; set; }
        public string Emails { get; set; } = null!;
        public string ReviewType { get; set; } = null!;
        public DateTime ReviewStart { get; set; }
        public DateTime ReviewEnd { get; set; }
    }
}
