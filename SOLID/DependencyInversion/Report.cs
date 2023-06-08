namespace DependencyInversion
{

    /*
     * Küçük sistem büyüğe değil; büyük sistem küçüğe bağlı olmalı.
     * Küçük sistem büyüğe dışardan gönderilmeli
     */

    public class Report
    {
        ISender sender;
        public Report(ISender sender)
        {

            this.sender = sender;
        }
        public void SendReport(string to)
        {

            sender.Send(to);
        }
    }

    public interface ISender
    {
        void Send(string to);
    }
    public class MailSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine($"{to} adresine mail gönderildi");
        }
    }
    public class WSSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("Whatsapp...");
        }
    }
    public class TelegramSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("Telegram");

        }
    }

}
