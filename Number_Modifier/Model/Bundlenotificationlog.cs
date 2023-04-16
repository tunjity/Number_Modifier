using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Bundlenotificationlog
    {
        public int Id { get; set; }
        public string? Financier { get; set; }
        public DateTime Created { get; set; }
        public string? Msisdn { get; set; }
    }
}
