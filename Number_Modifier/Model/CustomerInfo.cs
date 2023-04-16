using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class CustomerInfo
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string KycInputName { get; set; } = null!;
        public string KycInputValue { get; set; } = null!;
        public bool Status { get; set; }
        public int PrecustomerId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}
