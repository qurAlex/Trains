namespace Trains.Server.Data.Models
{
    /// <summary>
    /// edges
    /// </summary>
    public class Info
    {
        public int Id { get; set; }
        public int CurrentStationId { get; set; }
        public int NextStationId { get; set; }
        public TimeSpan TimeToNextStation { get; set; }
        public double Distance { get; set; }

    }
}
