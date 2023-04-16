using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Permission
    {
        public Permission()
        {
            Rolepermissions = new HashSet<Rolepermission>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Section { get; set; }

        public virtual ICollection<Rolepermission> Rolepermissions { get; set; }
    }
}
