using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Paymentchannel
    {
        public Paymentchannel()
        {
            Paymentchannelparameters = new HashSet<Paymentchannelparameter>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Paymentchannelparameter> Paymentchannelparameters { get; set; }
    }
}
