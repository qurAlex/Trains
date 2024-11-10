using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trains.Server.Data;
using Trains.Server.Data.Models;
using Trains.Server.Data.SeedData;

namespace Trains.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrainsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private TrainsDbContext _trainsDbContext;

        public TrainsController(ILogger<WeatherForecastController> logger, TrainsDbContext trainsDbContext)
        {
            _logger = logger;
            _trainsDbContext = trainsDbContext;
        }

        [HttpGet]
        public IEnumerable<Train> Get()
        {
            SeedData seed = new SeedData(_trainsDbContext);
            seed.AddDefaultData();
            return _trainsDbContext.Trains.Include(x=>x.Schedules).Include(x=>x.Road).ToList();
        }
    }
}
