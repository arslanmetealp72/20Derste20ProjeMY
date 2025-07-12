using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project6_ApiWeather.Context;
using Project6_ApiWeather.Entities;

namespace Project6_ApiWeather.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Weathers : ControllerBase
    {
        WeatherContext context = new WeatherContext();

        [HttpGet]
        public IActionResult WeatherCityList()
        {
            var cities = context.Cities.ToList();
            return Ok(cities);
        }

        [HttpPost]
        public IActionResult CreateWeatherCity(City city)
        {
            context.Cities.Add(city);
            context.SaveChanges();
            return Ok("City added successfully.");
        }

        [HttpDelete]
        public IActionResult DeleteWeatherCity(int id)
        {
            var value = context.Cities.Find(id);
            context.Cities.Remove(value);
            context.SaveChanges();
            return Ok("City deleted successfully.");
        }

        [HttpPut]
        public IActionResult UpdateWeatherCity(City city)
        {
            var value = context.Cities.Find(city.CityId);
            value.CityName = city.CityName;
            value.Detail = city.Detail;
            value.Country = city.Country;
            value.Temp = city.Temp;
            context.SaveChanges();
            return Ok("City updated successfully.");
        }

        [HttpGet("GetWeatherCityById")]

        public IActionResult GetWeatherCityById(int id)
        {
            var value = context.Cities.Find(id);
            return Ok(value);
        }

        [HttpGet("TotalCityCount")]

        public IActionResult TotalCityCount()
        {
            var count = context.Cities.Count();
            return Ok(count);
        }
        [HttpGet("MaxTempCity")]

        public IActionResult MaxTempCity()
        {
            var maxTempCity = context.Cities.OrderByDescending(x => x.Temp).Select(y => y.CityName).FirstOrDefault();
            return Ok(maxTempCity);
        }
    }
}
