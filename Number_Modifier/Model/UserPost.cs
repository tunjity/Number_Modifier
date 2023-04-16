using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class UserPost
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; } = null!;
        public int CommChannelId { get; set; }
        public bool ChannelOnly { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int Thread { get; set; }
        public int Replyto { get; set; }
        public string? Attachments { get; set; }
        public string Type { get; set; } = null!;
        public int? CustomerRef { get; set; }
        public int? DeviceRef { get; set; }
        public int? DumpRef { get; set; }
        public int? TicketRef { get; set; }
        public int? TaskRef { get; set; }
        public int? LenderRef { get; set; }
        public int? TelcoRef { get; set; }
        public int? ActivityRef { get; set; }
        public bool Deleted { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
