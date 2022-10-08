using SamoleAPI.Models;
using SamoleAPI.Service.Interface;

namespace SamoleAPI.Service.Implementation
{
    public class AuthentcaietionService : IAuthentcaietionService
    {
        public Task<UserDto> LoginCheck(AuthenticationReqDto authenticationReqDto, TokenDto tokenDto, AppSettings appsetting)
        {
            var userDetails = new UserDto
            {
                Id = 1234,
                FirstName = "TestUserFirstName",
                LastName = "TestUserLastName",
                FullName = "TestUserFirstName" + "TestUserLastName",
                MobileNumber = "0123456789",
                AltMobileNumber = "9876543210",
                Email = "TestUserFirstName@test.com",
                Passoword = "123sdfadf5735345",
                Role = 56,
                Token = "3434354#$%$#hdsdgfjsdfj",
                EmailVerified = 1,
                MobileVerified = 1,
                WrongAttempts = 0,
                PassCode = "5456456",
                UserVerfied = true,
                Disabled = 0,
                CreatedDate = DateTime.Now,
                CreatedBy = "Admin",
                LastEditDate = DateTime.Now,
                LastEditedBy = "Admin",
                Active = 1
            };

            return Task.FromResult<UserDto>(userDetails);
        }
    }
}
