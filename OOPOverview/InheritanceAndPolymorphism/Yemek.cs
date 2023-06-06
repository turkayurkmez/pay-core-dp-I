namespace InheritanceAndPolymorphism
{
    public class Yemek
    {
        public int Sure { get; set; }
        public List<string> Malzemeler { get; set; } = new List<string>();
        public decimal Fiyat { get; set; }
        public void Pisir()
        {
            Console.WriteLine($"{GetType().Name} isimli yemek, {Sure} dakikada pişti");
        }

        public virtual void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} isimli yemek, yanında pilav ile sunuldu");
        }
    }

    public class SebzeYemegi : Yemek
    {
        public bool ZeytinYagliMi { get; set; }
    }

    public class TazeFasulye : SebzeYemegi
    {
        public string EkstraMalzeme { get; set; }
    }

    public class EtYemegi : Yemek
    {
        public int PismeOrani { get; set; }
    }
    public class Kofte : EtYemegi
    {

    }

    public class Baklava : Yemek
    {
        //public bool DondurmaOlsunMu { get; set; }
        public override void SunumYap()
        {
            Console.WriteLine($"{GetType().Name}, dondurma ile sunuldu ");
        }
    }

    public class Corba : Yemek
    {
        public override void SunumYap()
        {
            base.SunumYap();
        }
    }
}
