using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Utility
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public string Attr { get; set; } = null!;
        public string Val { get; set; } = null!;
    }
}
