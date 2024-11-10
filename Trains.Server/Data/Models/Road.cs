namespace Trains.Server.Data.Models
{
    public class Road
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DirectionId { get; set; }
        public Direction Direction { get; set; }
        public List<Train> Trains { get; set; }
    }
}
