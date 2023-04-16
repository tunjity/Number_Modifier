using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class User
    {
        public User()
        {
            Clusters = new HashSet<Cluster>();
            Deviceworkflows = new HashSet<Deviceworkflow>();
            RegionSupervisorMappings = new HashSet<RegionSupervisorMapping>();
            Subregions = new HashSet<Subregion>();
            Tickets = new HashSet<Ticket>();
            Userinfos = new HashSet<Userinfo>();
            Workflowapprovalusergroups = new HashSet<Workflowapprovalusergroup>();
        }

        public int Id { get; set; }
        public string Fname { get; set; } = null!;
        public string Lname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? Avatar { get; set; }
        public string? Pin { get; set; }
        public string? Username { get; set; }
        public string Password { get; set; } = null!;
        public int? CompanyId { get; set; }
        public string Role { get; set; } = null!;
        public bool? Activated { get; set; }
        public string? ActivatePass { get; set; }
        public DateTime? ActivationDt { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public float? AverageRating { get; set; }
        public string? PwdHash { get; set; }
        public DateTime? PwdHashExpires { get; set; }
        public string? PasswordHash { get; set; }
        public string? RepStatus { get; set; }

        public virtual ICollection<Cluster> Clusters { get; set; }
        public virtual ICollection<Deviceworkflow> Deviceworkflows { get; set; }
        public virtual ICollection<RegionSupervisorMapping> RegionSupervisorMappings { get; set; }
        public virtual ICollection<Subregion> Subregions { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<Userinfo> Userinfos { get; set; }
        public virtual ICollection<Workflowapprovalusergroup> Workflowapprovalusergroups { get; set; }
    }
}
