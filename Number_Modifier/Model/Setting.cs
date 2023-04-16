using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Setting
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
        public bool IsActive { get; set; }
    }
}
