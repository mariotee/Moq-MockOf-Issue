using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebApplication1.Controllers;
using static WebApplication1.Options;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ARRANGE
            var options = Mock.Of<IOptions<DatabaseOptions>>((m) =>
                m.Value.ConnectionString == "connection"
                    && m.Value.MaxConnections == 1);
            
            var controller = new WeatherForecastController(options, NullLogger<WeatherForecastController>.Instance);
            //ACT
            //ASSERT
        }
    }
}
