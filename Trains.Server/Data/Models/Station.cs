namespace Trains.Server.Data.Models
{
    /// <summary>
    /// nodes
    /// </summary>
    public class Station
    {
        public int Id { get; set; }

        /// <summary>
        /// [][][] - подразделение | город | номер
        /// </summary>
        public int Number { get; set; }
        public required string Name { get; set; }

        /// <summary>
        /// 0 - остановка, 1 - станция, 2 - вокзал
        /// </summary>
        public byte Type { get; set; }
        public List<Schedule> Schedules { get; set; }
        public List<Direction> Directions { get; set; }
        public List<StopTime> StopTimes { get; set; }
    }
}
