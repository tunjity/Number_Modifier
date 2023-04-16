using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Paystacktransferlog
    {
        public long Id { get; set; }
        public string? RecipientCode { get; set; }
        public decimal Amount { get; set; }
        public string? Source { get; set; }
        public string? Reason { get; set; }
        public string? PaystackTransferId { get; set; }
        public string? PaystackTransferCode { get; set; }
        public string? PaystackTransferRef { get; set; }
        public DateTime DateInitiated { get; set; }
        public string? TransferStatus { get; set; }
        public long PreCustomerId { get; set; }
        public string? WebhookStatus { get; set; }
        public DateTime? WebhookTimestamp { get; set; }
    }
}
