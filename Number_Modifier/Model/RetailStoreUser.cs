using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class RetailStoreUser
    {
        public int Id { get; set; }
        public int RetailStoreId { get; set; }
        public int UserId { get; set; }
    }
}
