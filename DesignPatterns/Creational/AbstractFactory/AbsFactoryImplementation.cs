namespace AbstractFactory
{


    public interface IMapCreator
    {
        List<IRecommendedVisitPoint> GetRecommendedVisitPoints();
        MapBase MapFormat();
        public string MapStyle { get; set; }
    }

    public class SatelliteCultureMap : IMapCreator
    {
        public string MapStyle { get; set; } = "Sattellite";

        private CultureMap cultureMap = new CultureMap();
        public List<IRecommendedVisitPoint> GetRecommendedVisitPoints()
        {
            return cultureMap.VisitPoints;
        }


        public MapBase MapFormat()
        {
            return cultureMap;
        }
    }

    public class RegionalReligionMap : IMapCreator
    {
        public string MapStyle { get; set; } = "Regional";

        private ReligionMap religionMap = new ReligionMap();
        public List<IRecommendedVisitPoint> GetRecommendedVisitPoints()
        {
            return religionMap.VisitPoints;
        }

        public MapBase MapFormat()
        {
            return religionMap;
        }
    }

    public class Map<TMapCreator> where TMapCreator : IMapCreator, new()
    {
        private TMapCreator mapCreator;
        public Map()
        {
            mapCreator = new TMapCreator();
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Oluşturulan harita türü: {mapCreator.MapFormat().GetType().Name} - Harita görünümü : {mapCreator.MapStyle} ");
            mapCreator.GetRecommendedVisitPoints().ForEach(vp => Console.WriteLine(vp.Title));
        }
    }



    public interface IRecommendedVisitPoint
    {
        string Title { get; set; }
        double Latitude { get; set; }
        double Longitude { get; set; }
        string APIUrl { get; set; }

    }

    public class Museum : IRecommendedVisitPoint
    {
        public string Title { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string APIUrl { get; set; }
    }

    public class Exhibition : IRecommendedVisitPoint
    {
        public string Title { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string APIUrl { get; set; }
    }

    public class Mosque : IRecommendedVisitPoint
    {
        public string Title { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string APIUrl { get; set; }
    }

    public class Tombs : IRecommendedVisitPoint
    {
        public string Title { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string APIUrl { get; set; }
    }
    public abstract class MapBase
    {
        public List<IRecommendedVisitPoint> VisitPoints { get; set; }
        public MapBase()
        {
            VisitPoints = new List<IRecommendedVisitPoint>();
            createVisitPoints();
        }

        //Factory Method:
        protected abstract void createVisitPoints();

    }
    public class CultureMap : MapBase
    {
        protected override void createVisitPoints()
        {
            VisitPoints.Add(new Museum { Title = "Topkapı Sarayı" });
            VisitPoints.Add(new Exhibition { Title = "İstanbul heykelleri sergisi" });
            VisitPoints.Add(new Museum { Title = "Yerebatan sarnıcı" });

        }
    }
    public class ReligionMap : MapBase
    {
        protected override void createVisitPoints()
        {
            VisitPoints.Add(new Mosque { Title = "Eyüp Sultan Camii" });
            VisitPoints.Add(new Tombs { Title = "......" });
            VisitPoints.Add(new Mosque { Title = "Ayasofya" });

        }
    }
}
