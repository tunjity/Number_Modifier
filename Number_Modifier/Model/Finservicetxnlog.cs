using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Finservicetxnlog
    {
        public int Id { get; set; }
        public int PrecustomerId { get; set; }
        public int? ActivationStatus { get; set; }
        public string? Syscomment { get; set; }
        public string? Manualcomment { get; set; }
        public string? RefNo { get; set; }
        public int? Manualcommentby { get; set; }
        public int? RetailerPaytStatus { get; set; }
        public int? InsurerPaytStatus { get; set; }
        public DateTime Created { get; set; }
    }
}
