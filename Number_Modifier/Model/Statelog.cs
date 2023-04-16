using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Statelog
    {
        public int Id { get; set; }
        public int PrecustomerId { get; set; }
        public string? Key { get; set; }
        public string? Val { get; set; }
        public string? Financier { get; set; }
    }
}
