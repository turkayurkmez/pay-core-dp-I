namespace Prototype
{
    public class Color : ICloneable
    {

        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        //public Random Random { get; set; }

        public Color()
        {
            //Bilerek uyduruk bir zaman ekliyoruz. 
            Thread.Sleep(3000);
            R = 0;
            G = 0;
            B = 0;
        }

        public override string ToString()
        {
            return $"{R}-{G}-{B}";
        }

        public object Clone()
        {
            return MemberwiseClone();
            //Şu anda yüzeysel olarak yani Color sınıfının sadece primitif özelliklerini kopyalar. Eğer kompleks bir property varsa bunun da klonunu almak isterseniz; deep clone yapmanız gerekir.

        }
    }

}
