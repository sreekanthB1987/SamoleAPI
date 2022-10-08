namespace SamoleAPI.Models
{
    public class TokenDto
    {
        public string IpAddress { get; set; }

        public string UserHostAddress { get; set; }

        public string Url { get; set; }

        public string Channel { get; set; }

        public string Device { get; set; }

        public string MobileNumber { get; set; }

        public string Otp { get; set; }

        public DateTime IssueDateTime { get; set; }
    }
}
