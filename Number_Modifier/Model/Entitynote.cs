using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Entitynote
    {
        public int Id { get; set; }
        public int? EntityTypeId { get; set; }
        public string? UserId { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
        public string? Flag { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string? EntityId { get; set; }
        public DateTime? LastDate { get; set; }
    }
}
