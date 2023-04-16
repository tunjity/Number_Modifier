using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Reportcategory
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string? CategoryPermissionCode { get; set; }
    }
}
