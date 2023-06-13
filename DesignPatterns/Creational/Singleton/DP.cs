namespace Singleton
{
    public interface ISender
    {
        void Send();
    }

    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail Gitti");
        }

        public string MailAddress { get; set; }

        private MailSender()
        {

        }
        private static MailSender instance;
        public static MailSender CreateMailSender()
        {
            if (instance == null)
            {
                instance = new MailSender();
            }
            return instance;
        }
    }
}
