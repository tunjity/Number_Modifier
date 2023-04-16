using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Mtndump
    {
        public int Id { get; set; }
        public string Msisdn { get; set; } = null!;
        public string Logging { get; set; } = null!;
        public float? Collection { get; set; }
        public DateTime NextPaymDate { get; set; }
        public string FileName { get; set; } = null!;
        public string? FileContent { get; set; }
        public int RefId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
