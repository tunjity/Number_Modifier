using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class CustomerActivityLog
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Sector { get; set; } = null!;
        public string Method { get; set; } = null!;
        public int EntryNumber { get; set; }
        public string Description { get; set; } = null!;
        public string? OldData { get; set; }
        public string? NewData { get; set; }
        public string LogType { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string IpAddress { get; set; } = null!;
        public string UserBrowser { get; set; } = null!;
        public int ApiClientId { get; set; }
    }
}
