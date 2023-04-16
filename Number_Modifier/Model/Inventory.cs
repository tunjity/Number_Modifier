using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Inventory
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int DeviceTypeId { get; set; }
        public int DeviceCategoryId { get; set; }
        public int RetailStoreId { get; set; }
        public string DeviceImei { get; set; } = null!;
        public string DeviceStatus { get; set; } = null!;
        public int RepId { get; set; }
        public string Notes { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
