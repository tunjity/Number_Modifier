using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Settlementlog
    {
        public Settlementlog()
        {
            Settlementlogitems = new HashSet<Settlementlogitem>();
        }

        public long Id { get; set; }
        public string? BatchNo { get; set; }
        public string? UploadedBy { get; set; }
        public int ItemCount { get; set; }
        public string? FileName { get; set; }
        public DateTime DateUploaded { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime? DateProcessed { get; set; }
        public string? ProcessedBy { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<Settlementlogitem> Settlementlogitems { get; set; }
    }
}
