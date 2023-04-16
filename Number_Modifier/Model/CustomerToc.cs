using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class CustomerToc
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int TocId { get; set; }
        public DateTime Created { get; set; }
        public string? FinancierCode { get; set; }
    }
}
