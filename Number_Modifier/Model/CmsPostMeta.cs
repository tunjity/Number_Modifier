using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class CmsPostMeta
    {
        public int Id { get; set; }
        public string Metaname { get; set; } = null!;
        public string Metavalue { get; set; } = null!;
        public int CmsPostId { get; set; }
        public int ParentId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
