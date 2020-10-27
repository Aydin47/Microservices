using System;

namespace UserService.Database.Entities
{
    public class WeatherForecasts
    {
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}

