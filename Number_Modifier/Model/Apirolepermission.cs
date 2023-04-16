using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Apirolepermission
    {
        public long Id { get; set; }
        public string? RoleName { get; set; }
        public string? Service { get; set; }
        public string? EndPoint { get; set; }
        public int CreatedById { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime DateCreated { get; set; }
        public string? CreatedBy { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastDateUpdated { get; set; }
    }
}
