using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Devicemanualextentionhistory
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public string? Msisdn { get; set; }
        public string? Comment { get; set; }
        public int ExtendedNoOfDays { get; set; }
        public DateTime ExtentionDate { get; set; }
    }
}
