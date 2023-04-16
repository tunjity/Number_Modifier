using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Reporttype
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
