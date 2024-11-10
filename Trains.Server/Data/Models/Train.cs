namespace Trains.Server.Data.Models
{
    public class Train
    {
        public int Id { get; set; }
        /// <summary>
        /// [][][][] подразделение отправления | подразделение прибытия | номер
        /// </summary>
        public int Number { get; set; }

        public int RoadId { get; set; }
        public Road Road { get; set; }
        public TimeSpan StartTime { get; set; }
        public List<DateTime> TrainDate { get; set; }
        public List<Schedule> Schedules { get; set; }
    }
}
