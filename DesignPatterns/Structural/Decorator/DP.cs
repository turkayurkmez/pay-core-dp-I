namespace Decorator
{
    public interface IMail
    {
        void Send();
    }

    public class PromotionMail : IMail
    {
        public void Send()
        {
            Console.WriteLine("Reklam maili atıldı");
        }
    }

    public class Newsletter : IMail
    {
        public void Send()
        {
            Console.WriteLine("Haftalık haberler gönderildi....");
        }
    }

    public class SignedMail : IMail
    {
        private IMail _mail;

        public SignedMail(IMail mail, string signedBy)
        {
            _mail = mail;
            SignedBy = signedBy;
        }

        public bool IsSigned { get; set; } = true;
        public string SignedBy { get; set; }

        public void Send()
        {
            if (IsSigned && !string.IsNullOrEmpty(SignedBy))
            {
                Console.WriteLine($"E-posta {SignedBy} tarafından imzalandı");
            }
            _mail.Send();
        }
    }

    public class CryptoMail : IMail
    {
        private IMail _mail;

        public CryptoMail(IMail mail)
        {
            _mail = mail;
        }

        public void Send()
        {
            Console.WriteLine("Mail şifrelendi");
            _mail.Send();
        }
    }
}
