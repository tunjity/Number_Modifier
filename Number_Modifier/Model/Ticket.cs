using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Ticket
    {
        public int Id { get; set; }
        public string CustomerMsisdn { get; set; } = null!;
        public int CustomerId { get; set; }
        public string Status { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Message { get; set; } = null!;
        public string Priority { get; set; } = null!;
        public string ServiceRating { get; set; } = null!;
        public int RepId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int Replyto { get; set; }
        public int Discussion { get; set; }
        public string? Sender { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual User Rep { get; set; } = null!;
    }
}
