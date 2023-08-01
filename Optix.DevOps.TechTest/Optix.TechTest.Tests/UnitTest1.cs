using Microsoft.Extensions.Options;
using Xunit;

namespace Optix.TechTest.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var options = Options.Create<WeatherConfig>(new WeatherConfig
            {
                FetchCount = 5
            });

            var service = new WeatherService(options);

            var response = service.Get();

            Assert.Equal(5, response.Count());
        }
    }
}