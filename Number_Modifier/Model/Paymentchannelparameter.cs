using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Paymentchannelparameter
    {
        public int Id { get; set; }
        public int PaymentChannelId { get; set; }
        public string? Mode { get; set; }
        public string? InputName { get; set; }
        public string? InputValue { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual Paymentchannel PaymentChannel { get; set; } = null!;
    }
}
