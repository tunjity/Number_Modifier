using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerInfos = new HashSet<CustomerInfo>();
            LoanRepayHistories = new HashSet<LoanRepayHistory>();
            LoanRepaySchedules = new HashSet<LoanRepaySchedule>();
            SimRegisters = new HashSet<SimRegister>();
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string Msisdn { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Status { get; set; } = null!;
        public int TelcoId { get; set; }
        public string? Imsi { get; set; }
        public string? PrequalifiedMsisdn { get; set; }
        public int PrequalifiedTelcoId { get; set; }
        public string Bvn { get; set; } = null!;
        public int CurrentDeviceId { get; set; }
        public int CurrentLoanId { get; set; }
        public int CurrentPlanId { get; set; }
        public DateTime OnboardDate { get; set; }
        public DateTime ActivationDate { get; set; }
        public bool LoginStatus { get; set; }
        public string Otp { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string? Pin { get; set; }
        public string? SecurityQuestion { get; set; }
        public float? Score { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? Avatar { get; set; }
        public string? PaelytRefno { get; set; }

        public virtual ICollection<CustomerInfo> CustomerInfos { get; set; }
        public virtual ICollection<LoanRepayHistory> LoanRepayHistories { get; set; }
        public virtual ICollection<LoanRepaySchedule> LoanRepaySchedules { get; set; }
        public virtual ICollection<SimRegister> SimRegisters { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
