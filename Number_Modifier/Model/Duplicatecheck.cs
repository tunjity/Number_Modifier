using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Duplicatecheck
    {
        public int Id { get; set; }
        public string RefNo { get; set; } = null!;
        public DateTime Created { get; set; }
    }
}
