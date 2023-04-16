using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Userinfo
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int UserId { get; set; }
        public string? InputName { get; set; }
        public string? InputValue { get; set; }
        public int? UsersId { get; set; }

        public virtual User? Users { get; set; }
    }
}
