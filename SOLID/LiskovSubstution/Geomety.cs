namespace LiskovSubstution
{

    /*
     * Bir base class ile derived class birbirlerinin yerine kullanılabilir olmalıdır.
     * Başka bir deyişle; miras alan, verenin davranışına müdahale edemez.
     */
    public interface IArea
    {
        int GetArea();
    }
    public class Rectangle : IArea
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea() => Width * Height;
    }

    public class Square : IArea //: Rectangle
    {
        //public override int Height { get => base.Height; set { base.Height = value; base.Width = value; } }
        //public override int Width { get => base.Width; set { base.Height = value; base.Width = value; } }
        public int EdgeLength { get; set; }

        public int GetArea()
        {
            return (int)Math.Pow(EdgeLength, 2);
        }
    }

    public static class RectangleFactory
    {
        public static IArea Create(int unit1, int? unit2 = null)
        {
            //varsayın ki kare döndürmeniz gerekti....
            return unit2.HasValue ? new Rectangle { Width = unit1, Height = unit2.Value } : new Square { EdgeLength = unit1 };
            //return new Square();

        }
    }

}
