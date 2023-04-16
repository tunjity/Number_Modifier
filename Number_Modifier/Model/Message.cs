using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Message
    {
        public int Id { get; set; }
        public string? NotifyType { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
