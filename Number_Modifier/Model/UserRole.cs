using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class UserRole
    {
        public UserRole()
        {
            Rolepermissions = new HashSet<Rolepermission>();
        }

        public int Id { get; set; }
        public string Tagname { get; set; } = null!;
        public string Title { get; set; } = null!;

        public virtual ICollection<Rolepermission> Rolepermissions { get; set; }
    }
}
