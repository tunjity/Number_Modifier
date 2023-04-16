using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Device
    {
        public Device()
        {
            Deviceworkflows = new HashSet<Deviceworkflow>();
            LoanRepayHistories = new HashSet<LoanRepayHistory>();
            LoanRepaySchedules = new HashSet<LoanRepaySchedule>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Oem { get; set; } = null!;
        public string Imei { get; set; } = null!;
        public string Imsi { get; set; } = null!;
        public string? SN { get; set; }
        public string? PO { get; set; }
        public string? CtnNo { get; set; }
        public int DeviceTypeId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerMsisdn { get; set; } = null!;
        public string CustomerImsi { get; set; } = null!;
        public string OldMsisdn { get; set; } = null!;
        public string OldImsi { get; set; } = null!;
        public int DistributorId { get; set; }
        public int RetailStoreId { get; set; }
        public int RepId { get; set; }
        public string Status { get; set; } = null!;
        public string? AionStatus { get; set; }
        public DateTime? ActivationDate { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string? Notes { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }

        public virtual ICollection<Deviceworkflow> Deviceworkflows { get; set; }
        public virtual ICollection<LoanRepayHistory> LoanRepayHistories { get; set; }
        public virtual ICollection<LoanRepaySchedule> LoanRepaySchedules { get; set; }
    }
}
