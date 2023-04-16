using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class ValueInfo
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string? KeyId { get; set; }
        public string? Value { get; set; }
    }
}
