using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class Bank
    {
        public Bank()
        {
            Bankrefs = new HashSet<Bankref>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string? SortCode { get; set; }

        public virtual ICollection<Bankref> Bankrefs { get; set; }
    }
}
