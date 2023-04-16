using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class CmsPost
    {
        public int Id { get; set; }
        public string PostTitle { get; set; } = null!;
        public string Tagline { get; set; } = null!;
        public string PostContent { get; set; } = null!;
        public int Author { get; set; }
        public int PostParent { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Publish { get; set; } = null!;
    }
}
