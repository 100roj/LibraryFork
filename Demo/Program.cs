namespace Demo
{
    using System;
    using System.Linq;
    using DataAccess;
    using DataAccess.Repositories;
    using Domain;

    internal class Program
    {
        private static void Main()
        {
            var ServiceStation = new ServiceStation(1, "Mikhail Arisatov", "Tartarovskiy ave. 53");
            var ServiceStation1 = new ServiceStation(2, "Ekaterina Schomieva", "Pushkinskaya st. 64");
            var ServiceStation2 = new ServiceStation(3, "Yuri Narumov", "Dozhdevoy val. 17");
            var ServiceStation3 = new ServiceStation(4, "Rinat Amamiyan", "Koshachiy ln. 28");

            var TL1 = new TrafficLight(1, "Tartarovskiy ave.-Aviamotornaya st.", ServiceStation);
            var TL2 = new TrafficLight(2, "20 letiya S.E.E.S.", ServiceStation1);
            var TL3 = new TrafficLight(3, "Amaginskaya st.-Satonkovo st.", ServiceStation2);
            var TL4 = new TrafficLight(4, "Koshachiy ln.", ServiceStation3);

            Console.WriteLine($"{TL1} {ServiceStation}");

            var settings = new Settings();

            settings.AddDatabaseServer(@"DESKTOP-1U2HID6\SQLEXPRESS");

            settings.AddDatabaseName("TrafficLightServer");

            using var sessionFactory = Configurator.GetSessionFactory(settings, showSql: true);

            using (var session = sessionFactory.OpenSession())
            {
                session.Save(TL1);
                session.Save(TL2);
                session.Save(TL3);
                session.Save(TL4);

                session.Save(ServiceStation);
                session.Save(ServiceStation1);
                session.Save(ServiceStation2);
                session.Save(ServiceStation3);
                session.Flush();
            }

            using (var session = sessionFactory.OpenSession())
            {
                var repoTrafficLight = new TrafficLightRepository();
                Console.WriteLine("All Traffic Lights:");
                repoTrafficLight.GetAll(session)
                    .ToList().ForEach(Console.WriteLine);
                Console.WriteLine(new string('-', 25));

                var repoServiceStation = new ServiceStationRepository();
                Console.WriteLine("All Service Stations:");
                repoServiceStation.GetAll(session)
                    .ToList().ForEach(Console.WriteLine);
                Console.WriteLine(new string('-', 25));
            }
        }
    }
}
