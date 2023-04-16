using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class FinanceMovement
    {
        public int Id { get; set; }
        public string? UniqueIdentifier { get; set; }
        public string? Method { get; set; }
        public DateTime Created { get; set; }
    }
}
