using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Abbr { get; set; } = null!;
        public string Markup { get; set; } = null!;
        public string? MarkupUnicode { get; set; }
        public string? MarkupHexCode { get; set; }
        public string? MarkupHtmlCode { get; set; }
        public string? MarkupHtmlEntity { get; set; }
    }
}
