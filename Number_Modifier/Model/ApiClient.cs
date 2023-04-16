using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class ApiClient
    {
        public int Id { get; set; }
        public string? ClientUserIdentity { get; set; }
        public string? AppKey { get; set; }
        public string? AppSecret { get; set; }
        public string Hash { get; set; } = null!;
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public int? Status { get; set; }
        public string? Whitelist { get; set; }
        public string? RoleName { get; set; }
    }
}
