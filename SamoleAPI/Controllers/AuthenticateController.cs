using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SamoleAPI.Models;
using SamoleAPI.Service.Interface;

namespace SamoleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAuthentcaietionService _authentcaietionService;


        public AuthenticateController(IHttpContextAccessor httpContextAccessor, IAuthentcaietionService authentcaietionService)
        {
            _httpContextAccessor = httpContextAccessor;
            _authentcaietionService = authentcaietionService;
        }

        [HttpPost("loginauth")]
        public async Task<ResponseDto> LoginAuth([FromBody] AuthenticationReqDto _request)
        {
            var response = new ResponseDto();

            var appseting = new AppSettings
            {
                Key = "myKey",
                Value = "6567sdhfgsdjh"
            };

            var tokenDetails = new TokenDto()
            {
                IpAddress = Convert.ToString(_httpContextAccessor.HttpContext.Connection.RemoteIpAddress),
                UserHostAddress = Convert.ToString(_httpContextAccessor.HttpContext.Request.Headers["user-Agent"]),
                Url = "google.com",
                Channel = _httpContextAccessor.HttpContext.Request.Headers["Channel"].FirstOrDefault()?.Split(" ").Last(),
                Device = _httpContextAccessor.HttpContext.Request.Headers["Device"].FirstOrDefault()?.Split(" ").Last(),
                MobileNumber = _request.UserName,
                Otp = _request.OTP,
                IssueDateTime = DateTime.Now
            };

            var otpResponse = await _authentcaietionService.LoginCheck(_request, tokenDetails, appseting);
            if(otpResponse != null && otpResponse.UserVerfied == true)
            {
                response.Data = otpResponse;
                response.Code = 0;
                response.Token = otpResponse.Token;
            }
            else
            {
                response.Code = 1;
                response.Message = "Please enter login Credentials!";
            }

            return response;
        }
    }
}
