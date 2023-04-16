using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class VtuSchedule
    {
        public int Id { get; set; }
        public int VtuPlanId { get; set; }
        public int CustomerId { get; set; }
        public short NoOfPendingRenewals { get; set; }
        public DateTime RenewalDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
