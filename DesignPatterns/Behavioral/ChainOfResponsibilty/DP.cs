namespace ChainOfResponsibilty
{

    public class Reservation
    {
        public string Owner { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int ParticipantCount { get; set; }
        public string City { get; set; }
    }

    public abstract class Responsible
    {
        public Responsible()
        {

        }
        public Responsible(Responsible next)
        {
            Next = next;
        }

        public abstract void Handler(Reservation reservation);

        public Responsible Next { get; set; }

    }

    public class CheckOwnerResponsible : Responsible
    {
        public CheckOwnerResponsible(Responsible responsible) : base(responsible)
        {

        }

        public CheckOwnerResponsible()
        {

        }
        public override void Handler(Reservation reservation)
        {
            if (!string.IsNullOrEmpty(reservation.Owner))
            {
                Next.Handler(reservation);
            }
            else
            {
                throw new ArgumentException("kimin adına olduğu belli değil");
            }
        }

    }

    public class CheckInAndOut : Responsible
    {
        public CheckInAndOut(Responsible next) : base(next)
        {
        }
        public CheckInAndOut()
        {

        }
        public override void Handler(Reservation reservation)
        {
            if (reservation.CheckIn < reservation.CheckOut)
            {
                Next.Handler(reservation);
            }
            else
            {
                throw new ArgumentException("tarihler hatalı");
            }
        }
    }

    public class CompletedToDb : Responsible
    {
        public CompletedToDb(Responsible next) : base(next)
        {
        }
        public CompletedToDb()
        {

        }
        public override void Handler(Reservation reservation)
        {
            Console.WriteLine($"{reservation.Owner} tarafından gerçekleştirilen rez. onaylandı");
        }

    }
}
