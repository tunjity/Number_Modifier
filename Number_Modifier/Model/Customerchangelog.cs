using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Customerchangelog
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string? ChangeType { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public string? Comment { get; set; }
        public DateTime Created { get; set; }
        public string? CustomerType { get; set; }
        public string? UserId { get; set; }
    }
}
