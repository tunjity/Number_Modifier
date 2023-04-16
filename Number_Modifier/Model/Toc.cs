using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Toc
    {
        public int Id { get; set; }
        public string? Contents { get; set; }
        public DateTime Created { get; set; }
        public bool? IsActive { get; set; }
        public string? Financier { get; set; }
    }
}
