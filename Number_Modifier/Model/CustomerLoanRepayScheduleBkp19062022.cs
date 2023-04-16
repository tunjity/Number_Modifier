using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class CustomerLoanRepayScheduleBkp19062022
    {
        public int CustomerId { get; set; }
        public string ScheduleMonthlyAnniversay { get; set; } = null!;
        public DateTime? RepaymentMonthlyAnniversay { get; set; }
    }
}
