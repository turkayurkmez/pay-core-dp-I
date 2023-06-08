namespace Builder.DesignPattern
{
    /*
     * Problem:
     *   Özelleşebilir çok aşamanın sırayla (veya sırasız) çalışmasıyla elde edilecek bir nesne olsun. Bu aşamaları nasıl bir araya getirirsiniz?
     *   
     * Senaryo:
     *  Bir api uygulamasında bir doküman çıktısı oluşturulmaktadır. Doküman; başlık, içerik, grafik gibi bölümlerden oluşmaktadır. İstemci Builder aracılığı ile bu dokümanı nasıl üretir?
     */

    public enum DocumentType
    {
        Product,
        Service
    }
    public class Document
    {
        public DocumentType Type { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Graph { get; set; }
        public void ShowDocumentDetails()
        {
            Console.WriteLine($"Dokümanın başlığı: {Title}");
            Console.WriteLine($"Dokümanın başlığı: {Content}");
            Console.WriteLine($"Dokümanın başlığı: {Graph}");


        }
    }
    public abstract class DocumentBuilder
    {
        public Document Document { get; set; } = new Document();
        public abstract void CreateTitle();
        public abstract void CreateContent();
        public abstract void CreateGraph();


    }

    public class ProductDocumentBuilder : DocumentBuilder
    {
        public override void CreateContent()
        {
            this.Document.Content = "Ürün kataloğunun içeriği db'den çekildi";
        }

        public override void CreateGraph()
        {
            this.Document.Graph = "Ürün kataloğunun grsfiği db'den çekilerek pasta......";
        }

        public override void CreateTitle()
        {
            this.Document.Title = "Ürün kataloğunun başlığı db'den çekildi";
        }
    }

    public class ServiceDocumentBuilder : DocumentBuilder
    {
        public override void CreateContent()
        {
            this.Document.Content = "Servis kataloğunun içeriği db'den çekildi";
        }

        public override void CreateGraph()
        {
            this.Document.Content = "Servis kataloğunun grsfiği db'den çekilerek pasta......";
        }

        public override void CreateTitle()
        {
            this.Document.Content = "Servis kataloğunun başlığı db'den çekildi";
        }
    }


}

