using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Precustnobvn
    {
        public int Id { get; set; }
        public string Msisdn { get; set; } = null!;
        public int Score { get; set; }
        public string? BvnNumber { get; set; }
        public string? IdNumber { get; set; }
        public string? BvnStatus { get; set; }
        public string? IdStatus { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public int CustomerId { get; set; }
        public int DeviceId { get; set; }
        public bool CustomerStatus { get; set; }
        public bool VerifyStatus { get; set; }
        public int? BvnCheckCount { get; set; }
        public string? NonuserReason { get; set; }
        public string? BvnDump { get; set; }
        public string? IdDump { get; set; }
        public string? OnboardingStatus { get; set; }
        public string? Dob { get; set; }
        public string? RiskClass { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string? TempOtp { get; set; }
        public string? AvatarGen { get; set; }
        public string? RefNo { get; set; }
        public string? Datasource { get; set; }
        public int FamilyPlannerCustomer { get; set; }
        public DateTime? DateCompleted { get; set; }
        public int? DeviceOptionId { get; set; }
        public string? Imei { get; set; }
        public string? RepCurrentStatus { get; set; }
        public int? RepId { get; set; }
        public int? BundleDeviceTypeId { get; set; }
        public string? Remarks { get; set; }
    }
}
