using System.Threading.Tasks;
using DistantPointExe.Models.TokenAuth;
using DistantPointExe.Web.Controllers;
using Shouldly;
using Xunit;

namespace DistantPointExe.Web.Tests.Controllers
{
    public class HomeController_Tests: DistantPointExeWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}