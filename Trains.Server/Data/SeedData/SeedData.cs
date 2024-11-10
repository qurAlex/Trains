using Microsoft.EntityFrameworkCore;
using Trains.Server.Data.Models;

namespace Trains.Server.Data.SeedData
{
    public class SeedData(TrainsDbContext _context)
    {
        public void AddDefaultData()
        {
            _context.Database.Migrate();

            if (!_context.Stations.Any())
            {
                _context.AddRange(new List<Station>()
                {
                    new () {Number = 1101, Name = "Минск-Пассажирский", Type =  2},
                    new () {Number = 1126, Name = "Молодечно", Type =  2},
                    new () {Number = 1120, Name = "Лоси", Type =  0},
                    new () {Number = 1121, Name = "Уша", Type =  1},
                    new () {Number = 1110, Name = "Беларусь", Type =  1},
                    new () {Number = 1141, Name = "Гудогай", Type =  1},
                    new () {Number = 1223, Name = "Лида", Type =  2},
                    new () {Number = 2, Name = "Гродно", Type =  2},
                    new () {Number = 4, Name = "Гомель", Type =  2},
                    new () {Number = 3, Name = "Брест", Type =  2},
                    new () {Number = 1, Name = "Борисов", Type =  2},
                    new () {Number = 2, Name = "Барановичи", Type =  2},
                    new () {Number = 1102, Name = "Минск-Северный", Type =  0},
                    new () {Number = 1105, Name = "Ждановичи", Type =  0},
                    new () {Number = 1107, Name = "Ратомка", Type =  1},
                    new () {Number = 1108, Name = "Крыжовка", Type =  0},
                    new () {Number = 1103, Name = "Масюковщина", Type =  0},
                    new () {Number = 1104, Name = "Лебяжий", Type =  0},
                    new () {Number = 1106, Name = "Минское море", Type =  0},
                    new () {Number = 1109, Name = "Зеленое", Type =  0},
                    new () {Number = 1111, Name = "Хмелевка", Type =  0},
                    new () {Number = 1112, Name = "Анусино", Type =  0},
                    new () {Number = 1113, Name = "Радошковичи", Type =  1},
                    new () {Number = 1114, Name = "Вязынка", Type =  0},
                    new () {Number = 1115, Name = "Пралески", Type =  0},
                    new () {Number = 1116, Name = "Дубравы", Type =  0},
                    new () {Number = 1117, Name = "Романы", Type =  0},
                    new () {Number = 1118, Name = "Олехновичи", Type =  1},
                    new () {Number = 1119, Name = "Бояры", Type =  0},
                    new () {Number = 1122, Name = "Мясота", Type =  0},
                    new () {Number = 1123, Name = "Татарщизна", Type =  0},
                    new () {Number = 1124, Name = "Криница", Type =  0},
                    new () {Number = 1125, Name = "Фестивальный", Type =  0},
                    new () {Number = 1127, Name = "Насилово", Type =  0},
                    new () {Number = 1128, Name = "Асановский", Type =  0},
                    new () {Number = 1129, Name = "Мороськи", Type =  0},
                    new () {Number = 1130, Name = "Пруды", Type =  0},
                    new () {Number = 1131, Name = "Засковичи", Type =  0},
                    new () {Number = 1132, Name = "Залесье", Type =  0},
                    new () {Number = 1133, Name = "Белосельский", Type =  0},
                    new () {Number = 1134, Name = "Молодежный", Type =  0},
                    new () {Number = 1135, Name = "Сморгонь", Type =  0},
                    new () {Number = 1136, Name = "Гаути", Type =  0},
                    new () {Number = 1137, Name = "Солы", Type =  0},
                    new () {Number = 1138, Name = "Ошмяны", Type =  0},
                    new () {Number = 1139, Name = "Скрестины", Type =  0},
                    new () {Number = 1201, Name = "Каледино", Type =  0},
                    new () {Number = 1202, Name = "Сечки", Type =  0},
                    new () {Number = 1203, Name = "Полочаны", Type =  1},
                    new () {Number = 1204, Name = "Литва", Type =  0},
                    new () {Number = 1205, Name = "Березинское", Type =  0},
                    new () {Number = 1206, Name = "Шипуличи", Type =  0},
                    new () {Number = 1207, Name = "Воложин", Type =  1},
                    new () {Number = 1208, Name = "Листопады", Type =  0},
                    new () {Number = 1209, Name = "Ластоянцы", Type =  0},
                    new () {Number = 1210, Name = "Мельковщизна", Type =  0},
                    new () {Number = 1211, Name = "Богданов", Type =  1},
                    new () {Number = 1212, Name = "Войгяны", Type =  0},
                    new () {Number = 1213, Name = "Яхимовщина", Type =  0},
                    new () {Number = 1214, Name = "Довгердишки", Type =  0},
                    new () {Number = 1215, Name = "Юратишки", Type =  1},
                    new () {Number = 1216, Name = "Лобачи", Type =  0},
                    new () {Number = 1217, Name = "Березовцы", Type =  0},
                    new () {Number = 1218, Name = "Гавья", Type =  1},
                    new () {Number = 1219, Name = "Князюковцы", Type =  0},
                    new () {Number = 1220, Name = "Кирьяновцы", Type =  0},
                    new () {Number = 1221, Name = "Цверма", Type =  1},
                    new () {Number = 1222, Name = "Гутно", Type =  0},
                });


                _context.SaveChanges();
            }

            if (!_context.Info.Any())
            {
                var number = 1101;
                var number1 = 1102;
                var rndTime = new Random();
                var rndDistance = new Random();
                var info = new List<Info>();
                while (number <= 1125)
                {
                    var currentStation = _context.Stations.First(s => s.Number == number).Id;
                    var nextStation = _context.Stations.First(s => s.Number == number1).Id;
                    number++;
                    number1++;

                    info.Add(
                        new()
                        {
                            CurrentStationId = currentStation,
                            NextStationId = nextStation,
                            TimeToNextStation = new TimeSpan(0, rndTime.Next(1, 9), 0),
                            Distance = rndDistance.Next(3, 15)
                        });
                }
                _context.AddRange(info);


                _context.SaveChanges();
            }

            if (!_context.Directions.Any())
            {
                _context.Directions.Add(new Direction
                {
                    Name = "Минск-Пассажирский - Молодечно",
                    Stations = _context.Stations.Where(x => x.Number >= 1101 && x.Number <= 1126).ToList(),
                    StartStationId = _context.Stations.First(x => x.Number == 1101).Id,
                    EndStationId = _context.Stations.First(x => x.Number == 1126).Id
                });

                _context.SaveChanges();
            }

            if (!_context.Roads.Any())
            {
                _context.Roads.AddRange(new List<Road>()
                {
                    new() {Name = "Минск-Пассажирский - Молодечно", Description = "со всеми остановками", Direction = _context.Directions.First()}
                });

                _context.SaveChanges();

            }


            if (!_context.StopTime.Any())
            {
                var defaultStopTimes = new List<StopTime>();
                var road = _context.Roads.Include(x => x.Direction.Stations).First();
                foreach (var station in road.Direction.Stations)
                {
                    var stopTime = new TimeSpan();
                    switch (station.Type)
                    {
                        case 0:
                            stopTime = new TimeSpan(0, 2, 0);
                            break;
                        case 1:
                            stopTime = new TimeSpan(0, 3, 0);
                            break;
                        case 2:
                            stopTime = new TimeSpan(0, 10, 0);
                            break;
                    }
                    defaultStopTimes.Add(new StopTime() { Road = road, Station = station, Time = stopTime });
                }

                defaultStopTimes.Remove(defaultStopTimes.Find(x => x.Station.Id == 4));
                defaultStopTimes.Add(
                    new()
                    { Road = road, Station = road.Direction.Stations.Find(x => x.Id == 4), Time = new TimeSpan(0, 15, 0) }
                );
                _context.AddRange(defaultStopTimes);
                _context.SaveChanges();


            }

            if (!_context.Schedules.Any())
            {
                _context.Schedules.AddRange(new List<Schedule>()
                {
                    new() {Name ="Минск-Пассажирский",  TimeOnStation =new TimeSpan(00,00,00) ,   TimeOutStation =new TimeSpan(13,45,00) ,  StopTime = new TimeSpan(00,00,00),   StationId = _context.Stations.First(x=>x.Number==1101).Id },
                    new() {Name ="Минск-Северный",  TimeOnStation =new TimeSpan(13,45,00) ,   TimeOutStation =new TimeSpan(13,47,00) ,  StopTime = new TimeSpan(00,02,00),   StationId =_context.Stations.First(x=>x.Number==1102).Id },
                    new() {Name ="Масюковщина", TimeOnStation =new TimeSpan(13,55,00) ,   TimeOutStation =new TimeSpan(13,57,00) ,  StopTime = new TimeSpan(00,02,00),   StationId = _context.Stations.First(x=>x.Number==1103).Id },
                    new() {Name ="Лебяжий", TimeOnStation =new TimeSpan(14,02,00) ,   TimeOutStation =new TimeSpan(14,04,00) ,  StopTime = new TimeSpan(00,02,00),   StationId = _context.Stations.First(x=>x.Number==1104).Id },
                    new() {Name ="Ждановичи",   TimeOnStation =new TimeSpan(14,10,00) ,   TimeOutStation =new TimeSpan(14,12,00) ,  StopTime = new TimeSpan(00,02,00),   StationId =_context.Stations.First(x=>x.Number==1105).Id },
                    new() {Name ="Минское море",    TimeOnStation =new TimeSpan(14,17,00) ,   TimeOutStation =new TimeSpan(14,19,00) ,  StopTime = new TimeSpan(00,02,00),   StationId =_context.Stations.First(x=>x.Number==1106).Id },
                    new() {Name ="Ратомка", TimeOnStation =new TimeSpan(14,20,00) ,   TimeOutStation =new TimeSpan(14,23,00) ,  StopTime = new TimeSpan(00,03,00),   StationId = _context.Stations.First(x=>x.Number==1107).Id },
                    new() {Name ="Крыжовка",    TimeOnStation =new TimeSpan(14,29,00) ,   TimeOutStation =new TimeSpan(14,31,00) ,  StopTime = new TimeSpan(00,02,00),   StationId = _context.Stations.First(x=>x.Number==1108).Id },
                    new() {Name ="Зеленое", TimeOnStation =new TimeSpan(14,32,00) ,   TimeOutStation =new TimeSpan(14,34,00) ,  StopTime = new TimeSpan(00,02,00),   StationId = _context.Stations.First(x=>x.Number==1109).Id },
                    new() {Name ="Беларусь",    TimeOnStation =new TimeSpan(14,39,00) ,   TimeOutStation =new TimeSpan(14,42,00) ,  StopTime = new TimeSpan(00,03,00),   StationId = _context.Stations.First(x=>x.Number==1110).Id },
                    new() {Name ="Хмелевка",    TimeOnStation =new TimeSpan(14,43,00) ,   TimeOutStation =new TimeSpan(14,45,00) ,  StopTime = new TimeSpan(00,02,00),   StationId = _context.Stations.First(x=>x.Number==1111).Id },
                    new() {Name ="Анусино", TimeOnStation =new TimeSpan(14,52,00) ,   TimeOutStation =new TimeSpan(14,54,00) ,  StopTime = new TimeSpan(00,02,00),   StationId = _context.Stations.First(x=>x.Number==1112).Id },
                    new() {Name ="Радошковичи", TimeOnStation =new TimeSpan(15,00,00) ,   TimeOutStation =new TimeSpan(15,03,00) ,  StopTime = new TimeSpan(00,03,00),   StationId = _context.Stations.First(x=>x.Number==1113).Id },
                    new() {Name ="Вязынка", TimeOnStation =new TimeSpan(15,06,00) ,   TimeOutStation =new TimeSpan(15,08,00) ,  StopTime = new TimeSpan(00,02,00),   StationId =_context.Stations.First(x=>x.Number==1114).Id },
                    new() {Name ="Пралески",    TimeOnStation =new TimeSpan(15,10,00) ,   TimeOutStation =new TimeSpan(15,12,00) ,  StopTime = new TimeSpan(00,02,00),   StationId = _context.Stations.First(x=>x.Number==1115).Id },
                    new() {Name ="Дубравы", TimeOnStation =new TimeSpan(15,14,00) ,   TimeOutStation =new TimeSpan(15,16,00) ,  StopTime = new TimeSpan(00,02,00),   StationId = _context.Stations.First(x=>x.Number==1116).Id },
                    new() {Name ="Романы",  TimeOnStation =new TimeSpan(15,22,00) ,   TimeOutStation =new TimeSpan(15,24,00) ,  StopTime = new TimeSpan(00,02,00),   StationId = _context.Stations.First(x=>x.Number==1117).Id },
                    new() {Name ="Олехновичи",  TimeOnStation =new TimeSpan(15,25,00) ,   TimeOutStation =new TimeSpan(15,28,00) ,  StopTime = new TimeSpan(00,03,00),   StationId = _context.Stations.First(x=>x.Number==1118).Id },
                    new() {Name ="Бояры",   TimeOnStation =new TimeSpan(15,29,00) ,   TimeOutStation =new TimeSpan(15,31,00) ,  StopTime = new TimeSpan(00,02,00),   StationId = _context.Stations.First(x=>x.Number==1119).Id },
                    new() {Name ="Лоси",    TimeOnStation =new TimeSpan(15,34,00) ,   TimeOutStation =new TimeSpan(15,36,00) ,  StopTime = new TimeSpan(00,02,00),   StationId = _context.Stations.First(x=>x.Number==1120).Id },
                    new() {Name ="Уша", TimeOnStation =new TimeSpan(15,40,00) ,   TimeOutStation =new TimeSpan(15,55,00) ,  StopTime = new TimeSpan(00,15,00),   StationId =_context.Stations.First(x=>x.Number==1121).Id },
                    new() {Name ="Мясота",  TimeOnStation =new TimeSpan(15,57,00) ,   TimeOutStation =new TimeSpan(15,59,00) ,  StopTime = new TimeSpan(00,02,00),   StationId = _context.Stations.First(x=>x.Number==1122).Id },
                    new() {Name ="Татарщизна",  TimeOnStation =new TimeSpan(16,00,00) ,   TimeOutStation =new TimeSpan(16,02,00) ,  StopTime = new TimeSpan(00,02,00),   StationId = _context.Stations.First(x=>x.Number==1123).Id },
                    new() {Name ="Криница", TimeOnStation =new TimeSpan(16,08,00) ,   TimeOutStation =new TimeSpan(16,10,00) ,  StopTime = new TimeSpan(00,02,00),   StationId =_context.Stations.First(x=>x.Number==1124).Id },
                    new() {Name ="Фестивальный",    TimeOnStation =new TimeSpan(16,17,00) ,   TimeOutStation =new TimeSpan(16,19,00) ,  StopTime = new TimeSpan(00,02,00),   StationId = _context.Stations.First(x=>x.Number==1125).Id },
                    new() {Name ="Молодечно",  TimeOnStation =new TimeSpan(16,22,00)   , TimeOutStation =new TimeSpan(00,00,00) ,  StopTime = new TimeSpan(00,00,00),   StationId =_context.Stations.First(x=>x.Number==1126).Id },
                });

                _context.SaveChanges();
            }

            if (!_context.Trains.Any())
            {
                _context.Trains.AddRange(new List<Train>()
                {
                    new() {Road = _context.Roads.First(), Number = 2304, StartTime = new TimeSpan(13, 45, 0), Schedules = _context.Schedules.ToList(), TrainDate = new List<DateTime>()
                        {
                            DateTime.MinValue
                    }}
                });

                _context.SaveChanges();

            }

        }
    }
}
