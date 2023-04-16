using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Reportparameter
    {
        public int Id { get; set; }
        public int ReportId { get; set; }
        public string? FieldName { get; set; }
        public string? FieldType { get; set; }
        public bool IsCompulsory { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string? SelectAction { get; set; }

        public virtual Report Report { get; set; } = null!;
    }
}
