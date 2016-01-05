using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace WeatherApi.Core
{
    public class WeatherClient
    {
        private readonly IRestClient _restClient;

        public WeatherClient(IRestClient restClient)
        {
            _restClient = restClient;
        }

        public WeatherInformation GetWeather()
        {
            return null;
        }

    }

    public class WeatherInformation
    {
        
    }
}
