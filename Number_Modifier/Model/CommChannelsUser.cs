using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class CommChannelsUser
    {
        public int Id { get; set; }
        public int CommChannelId { get; set; }
        public int UserId { get; set; }
    }
}
