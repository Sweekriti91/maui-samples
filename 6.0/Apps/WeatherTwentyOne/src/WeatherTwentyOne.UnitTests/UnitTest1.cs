using WeatherDataService.Services;

namespace WeatherTwentyOne.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDummyPass()
        {
            Assert.Pass();
        }

        [Test]
        public void TestDummyFail()
        {
            Assert.Fail();
        }

        [Test]
        public void TestWeatherService()
        {
            IWeatherService weatherService = new WeatherService(null);
            var locations = weatherService.GetLocations(string.Empty);

            Assert.IsNotNull(locations);
           
        }
    }
}