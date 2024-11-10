namespace Trains.Server.Data.Models
{
    public class StopTime
    {
        public int Id { get; set; }
        public int RoadId { get; set; }
        public Road Road { get; set; }
        public int StationId { get; set; }
        public Station Station { get; set; }
        public TimeSpan Time { get; set; }
    }
}
