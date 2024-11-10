namespace Trains.Server.Data.Models
{
    public class Direction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartStationId { get; set; }
        public int EndStationId { get; set; }
        public List<Station> Stations { get; set; }
    }
}
