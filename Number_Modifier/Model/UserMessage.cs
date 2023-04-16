using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class UserMessage
    {
        public int Id { get; set; }
        public int Sender { get; set; }
        public int Recipient { get; set; }
        public string Message { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int Replyto { get; set; }
        public int Discussion { get; set; }
        public string? Sendtag { get; set; }
        public bool IsSent { get; set; }
        public bool IsRead { get; set; }
        public bool IsTrashed { get; set; }
    }
}
