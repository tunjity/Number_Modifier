﻿using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Vwbvndetail
    {
        public int Id { get; set; }
        public int PreCustomerId { get; set; }
        public string Bvn { get; set; } = null!;
        public string? Value { get; set; }
    }
}
