using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Ledger
    {
        public Ledger()
        {
            Ledgertransactiondetails = new HashSet<Ledgertransactiondetail>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public bool IsFlat { get; set; }
        public string? ProposedFormular { get; set; }
        public string? ActualFormular { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Ledgertransactiondetail> Ledgertransactiondetails { get; set; }
    }
}
