using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class SimRegister
    {
        public int Id { get; set; }
        public string Msisdn { get; set; } = null!;
        public string Pin { get; set; } = null!;
        public bool LoginStatus { get; set; }
        public int TelcoId { get; set; }
        public string Status { get; set; } = null!;
        public int CustomerId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Otp { get; set; } = null!;
        public int CurrentDeviceId { get; set; }
        public int CurrentLoanId { get; set; }
        public int CurrentPlanId { get; set; }
        public DateTime OnboardDate { get; set; }
        public DateTime ActivationDate { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}
