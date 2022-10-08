namespace SamoleAPI.Models
{
    public class ResponseDto
    {
        public int Code { get; set; }

        public string Message { get; set; }

        public dynamic Data { get; set; }

        public string ErrorCode { get; set; }

        public string Token { get; set; }
    }
}
