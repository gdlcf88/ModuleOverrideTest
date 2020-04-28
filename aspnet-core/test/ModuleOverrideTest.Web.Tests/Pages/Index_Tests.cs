using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ModuleOverrideTest.Pages
{
    public class Index_Tests : ModuleOverrideTestWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
