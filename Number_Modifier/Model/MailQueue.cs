using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class MailQueue
    {
        public int Id { get; set; }
        public string Sender { get; set; } = null!;
        public string Recipient { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Viewvars { get; set; } = null!;
        public string MsgTemplate { get; set; } = null!;
        public int? UserId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
