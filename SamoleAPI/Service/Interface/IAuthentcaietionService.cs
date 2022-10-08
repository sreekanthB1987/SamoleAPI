using SamoleAPI.Models;

namespace SamoleAPI.Service.Interface
{
    public interface IAuthentcaietionService
    {
        Task<UserDto> LoginCheck(AuthenticationReqDto authenticationReqDto, TokenDto tokenDto, AppSettings appsetting);
    }
}
