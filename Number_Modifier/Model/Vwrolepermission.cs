using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Vwrolepermission
    {
        public int Id { get; set; }
        public string Role { get; set; } = null!;
        public string? Permission { get; set; }
    }
}
