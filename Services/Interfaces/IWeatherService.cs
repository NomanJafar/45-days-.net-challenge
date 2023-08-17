using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLDatabase.Entities;

namespace Services.Interfaces
{
    public interface IWeatherService
    {
        public IEnumerable<WeatherForecastModel> GetWeatherForecast();
    }
}
