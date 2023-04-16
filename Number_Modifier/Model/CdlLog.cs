using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class CdlLog
    {
        public int Id { get; set; }
        public int? PrecustomerId { get; set; }
        public bool? IsCompleted { get; set; }
        public int? RefNo { get; set; }
        public string? UserName { get; set; }
        public int? Amount { get; set; }
        public long? ClientId { get; set; }
        public int? LoanId { get; set; }
        public string? Signature { get; set; }
        public bool? IsSignatureSent { get; set; }
        public DateTime? Created { get; set; }
    }
}
