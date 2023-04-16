using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class DataDumps200123
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public string Ref { get; set; } = null!;
        public string? Provider { get; set; }
        public string Dump { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
