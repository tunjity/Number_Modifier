using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class EnterpriseBundleClassification
    {
        public int Id { get; set; }
        public string BundleName { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Status { get; set; } = null!;
    }
}
