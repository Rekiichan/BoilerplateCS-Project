using System.Threading.Tasks;
using MyPrjTest.Models.TokenAuth;
using MyPrjTest.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyPrjTest.Web.Tests.Controllers
{
    public class HomeController_Tests: MyPrjTestWebTestBase
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