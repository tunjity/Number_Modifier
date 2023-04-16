using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class EnterpriseBundlePlan
    {
        public int Id { get; set; }
        public int EnterpriseBundleId { get; set; }
        public int EnterprisePlanId { get; set; }
        public int DataPerMonth { get; set; }
        public int VoicePerMonth { get; set; }
        public decimal FinanceAmount { get; set; }
        public decimal InterestPercent { get; set; }
        public decimal IntelligraSupportFee { get; set; }
        public decimal FinancingPartyFee { get; set; }
        public decimal TotalBundleCharge { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Status { get; set; } = null!;
        public decimal InitialDeposit { get; set; }
        public int RefLoanId { get; set; }
        public int RefPlanId { get; set; }

        public virtual EnterpriseBundle EnterpriseBundle { get; set; } = null!;
        public virtual EnterprisePlan EnterprisePlan { get; set; } = null!;
    }
}
