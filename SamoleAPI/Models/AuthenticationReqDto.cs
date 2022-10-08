namespace SamoleAPI.Models
{
    public class AuthenticationReqDto
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Token { get; set; }

        public string OTP { get; set; }

        public string SessionId { get; set; }

        public string Device { get; set; }

        public string Pin { get; set; }
    }
}
