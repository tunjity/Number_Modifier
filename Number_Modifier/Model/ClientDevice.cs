using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class ClientDevice
    {
        public int Id { get; set; }
        public string Uuid { get; set; } = null!;
        public string PushToken { get; set; } = null!;
        public string ProfileToken { get; set; } = null!;
        public DateTime LastAccess { get; set; }
        public int? Blocked { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
