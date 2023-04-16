using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class PriceList
    {
        public int Id { get; set; }
        public int DeviceTypeId { get; set; }
        public int RetailStoreId { get; set; }
        public float Amount { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
