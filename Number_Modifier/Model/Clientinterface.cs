using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Clientinterface
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? DomainUrl { get; set; }
        public string? BrandColour { get; set; }
        public string? LogoUrl { get; set; }
        public int Oem { get; set; }
        public int Financier { get; set; }
        public int Telco { get; set; }
        public int Tenure { get; set; }
        public bool IsUrlProvisioned { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool AutoApprove { get; set; }
        public bool IsCustomeKyc { get; set; }
        public string? LandingPhrase { get; set; }
        public string? LandingImage { get; set; }
        public bool IsAgentCodeRequired { get; set; }
        public bool IsDefault { get; set; }
        public string? Address { get; set; }
        public bool LogoBackground { get; set; }
    }
}
