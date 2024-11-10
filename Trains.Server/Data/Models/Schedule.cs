namespace Trains.Server.Data.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan TimeOnStation { get; set; }
        public TimeSpan TimeOutStation { get; set; }
        public TimeSpan StopTime { get; set; }
        public int StationId { get; set; }
        public Station Station { get; set; }
        public List<Train> Trains { get; set; }
    }
}
