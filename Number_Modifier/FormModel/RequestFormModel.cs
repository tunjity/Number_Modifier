using System.ComponentModel.DataAnnotations;

namespace Number_Modifier.FormModel
{
    public class RequestFormModel
    {
        [Required]
        public string OldNumber { get; set; }
        [Required]
        public string NewNumber { get; set; }
    }

    public class ApiResponse
    {
        public string code { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public object data { get; set; }
    }
}
