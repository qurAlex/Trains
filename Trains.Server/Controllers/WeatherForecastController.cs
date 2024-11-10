using Microsoft.AspNetCore.Mvc;
using Trains.Server.Data;
using Trains.Server.Data.SeedData;

namespace Trains.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private TrainsDbContext _trainsDbContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, TrainsDbContext trainsDbContext)
        {
            _logger = logger;
            _trainsDbContext = trainsDbContext;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            SeedData seed = new SeedData(_trainsDbContext);
            seed.AddDefaultData();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
