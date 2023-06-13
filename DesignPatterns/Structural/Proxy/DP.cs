namespace Proxy
{
    public interface IMath
    {
        double Add(double value1, double value2);
    }

    public class Math : IMath
    {
        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }
    }

    public class MathProxy : IMath
    {
        private Math math;

        public MathProxy(Math math)
        {
            this.math = math;
        }

        public double Add(double value1, double value2)
        {
            //1. Denetleme: Veriler doğru bir biçimde aktarılıyor mu?
            //2. Loglama: Akışı izleyebileceğiniz bir senaryo...

            return this.math.Add(value1, value2);
        }
    }
}
