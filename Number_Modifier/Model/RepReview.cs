using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class RepReview
    {
        public int Id { get; set; }
        public int RepId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string ReviewType { get; set; } = null!;
        public int DeviceId { get; set; }
        public int LoanAllocationId { get; set; }
        public DateTime OnboardingDate { get; set; }
        public string CustomerStatus { get; set; } = null!;
        public bool ImageUploadStatus { get; set; }
        public float RepRating { get; set; }
        public string Notes { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
