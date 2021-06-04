using System.Collections.Generic;
namespace ReportingReflection
{
    public class Weather
    {
        public string City { get; set; }
        public string Description { get; set; }
        public double TemperatureCentrigrade { get; set; }
        public double RainfallInches { get; set; }
    }

    public static class WeatherData
    {
        public static IEnumerable<Weather> Weather = new Weather[]
        {
            new () { City = "London", Description = "Sunny spells", TemperatureCentrigrade = 19, RainfallInches = 0 },
            new () { City = "Paris", Description = "Very hot", TemperatureCentrigrade = 27, RainfallInches = 0 },
            new () { City = "New York", Description = "Heavy rain", TemperatureCentrigrade = 8, RainfallInches = 6.598 },
            new () { City = "Munich", Description = "Foggy", TemperatureCentrigrade = 12, RainfallInches = 2.134 },
            new () { City = "Istanbul", Description = "Sunshine and showers", TemperatureCentrigrade = 22, RainfallInches = 8.5 },
            new () { City = "Santiago", Description = "Strong winds", TemperatureCentrigrade = 15, RainfallInches = 0.125 },
        };
    }
}
