
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using NSubstitute;
using Xunit;
using app;

namespace TestProject1
{
    public class UnitTest1
    {
        private functionApp? _functionApp;
    
        private ILoggerFactory loggerFactory = Substitute.For<ILoggerFactory>();
        
        [Fact]
        public async void Test1()
        {
            loggerFactory.CreateLogger(null).ReturnsForAnyArgs(NullLogger<functionApp>.Instance);

            _functionApp = new functionApp(loggerFactory);

            var result = await _functionApp.Run(2000, "Celsius");

            Assert.NotNull(result);
        }
    }
}