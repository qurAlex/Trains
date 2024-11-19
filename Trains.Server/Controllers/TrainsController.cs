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
        private readonly TrainsDbContext _trainsDbContext;

        public TrainsController(ILogger<WeatherForecastController> logger, TrainsDbContext trainsDbContext)
        {
            _logger = logger;
            _trainsDbContext = trainsDbContext;
        }
        [Route("GetTrains")]
        [HttpGet]
        public IEnumerable<Train> GetTrains()
        {
            SeedData seed = new SeedData(_trainsDbContext);
            seed.AddDefaultData();
            return _trainsDbContext.Trains.Include(x=>x.Schedules).Include(x=>x.Road).ToList();
        }

        [Route("GetTrain/{id}")]
        [HttpGet]
        public Train GetTrain(int id)
        {
	        return _trainsDbContext.Trains.Include(x=>x.Schedules).Include(x => x.Road).First(x => x.Id == id);
        }

        [Route("AddTrain")]
        [HttpPost]
        public void AddTrain(Train train)
        {

        }

        [Route("GetStations")]
        [HttpGet]
        public IEnumerable<Station> GetStations()
        {
	        return _trainsDbContext.Stations.ToList();
        }

        [Route("AddStation")]
        [HttpPost]
        public void AddStation(Station station)
        {

        }

        [Route("GetDirections")]
        [HttpGet]
        public IEnumerable<Direction> GetDirections()
        {
            return _trainsDbContext.Directions.ToList();
        }

        [Route("AddDirection")]
        [HttpPost]
        public void AddDirection(Direction direction)
        {

        }
	}
}
