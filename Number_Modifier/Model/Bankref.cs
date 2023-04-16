using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Bankref
    {
        public long Id { get; set; }
        public long? BankId { get; set; }
        public string? Gateway { get; set; }
        public string? GatewayCode { get; set; }
        public string? Name { get; set; }
        public string? GatewayLiveCode { get; set; }

        public virtual Bank? Bank { get; set; }
    }
}
