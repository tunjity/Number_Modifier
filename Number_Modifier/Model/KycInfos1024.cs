using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class KycInfos1024
    {
        public int Id { get; set; }
        public int PreCustomerId { get; set; }
        public string Type { get; set; } = null!;
        public string InputName { get; set; } = null!;
        public string InputValue { get; set; } = null!;
        public string InputType { get; set; } = null!;
        public int Sequence { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
