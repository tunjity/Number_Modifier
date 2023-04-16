using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class DeviceCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public int ParentId { get; set; }
        public string BrandName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int PartnerId { get; set; }
        public bool IsActive { get; set; }
    }
}
