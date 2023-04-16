using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class CommChannel
    {
        public int Id { get; set; }
        public string Slug { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool Private { get; set; }
    }
}
