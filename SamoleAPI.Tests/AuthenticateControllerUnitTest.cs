using FakeItEasy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using SamoleAPI.Controllers;
using SamoleAPI.Models;
using SamoleAPI.Service.Implementation;
using SamoleAPI.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SamoleAPI.Tests
{
    public class AuthenticateControllerUnitTest
    {
        private readonly IAuthentcaietionService _authentcaietionService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IServiceProvider _serviceProvider;

        public AuthenticateControllerUnitTest()
        {
            _authentcaietionService = A.Fake<IAuthentcaietionService>();
            _httpContextAccessor = A.Fake<HttpContextAccessor>();
            _serviceProvider = A.Fake<IServiceProvider>();
        }

        [Fact]
        public void TestPostSuccess()
        {
            _httpContextAccessor.HttpContext = new DefaultHttpContext
            {
                RequestServices = _serviceProvider
            };

            var requeststring = "{\"username\":\"testuser\",\"password\":\"123454\",\"token\":\"gdagdfg54564sdfsdf\"}";
            var authDto = JsonConvert.DeserializeObject<AuthenticationReqDto>(requeststring);
            var controller = new AuthenticateController(_httpContextAccessor, _authentcaietionService);
            var output = controller.LoginAuth(authDto);
            var actualResult = output.Result as ResponseDto;
            Assert.NotNull(output);
            Assert.True(actualResult is ResponseDto);
        }
    }
}
