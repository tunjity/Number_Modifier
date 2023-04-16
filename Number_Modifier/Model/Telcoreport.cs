using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Telcoreport
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Df { get; set; }
        public int Dh { get; set; }
        public long Mdf { get; set; }
        public long Mdr { get; set; }
        public int Renewals { get; set; }
    }
}
