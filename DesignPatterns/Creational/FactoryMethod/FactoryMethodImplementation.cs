namespace FactoryMethod
{
    /*
     *   KulturHarita kultur = new KulturHarita();
     *   kultur.ZiyaretNoktalari // işte bu koleksiyonu dolu bir biçimde gelecek!
     */
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

