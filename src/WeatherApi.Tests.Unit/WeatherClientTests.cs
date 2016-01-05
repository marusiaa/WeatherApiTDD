using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WeatherApi.Core;
using WeatherApi.Tests.Unit.Stubs;

namespace WeatherApi.Tests.Unit
{
    [TestFixture]
    public class WeatherClientTests
    {
        [Test]
        public void Should_return_expected_weather_information()
        {
            // given
            RestClientStub restClientStub = new RestClientStub();
            WeatherClient weatherClient = new WeatherClient(restClientStub);
            var expectedResult = new WeatherInformation();
            
            // when
            var result = weatherClient.GetWeather();

            // then
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
