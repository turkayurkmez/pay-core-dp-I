using System.Collections;

namespace AbstractAndInterface
{
    public abstract class Document
    {
        public string Owner { get; set; }
        public string Title { get; set; }
        public DateOnly? CreatedDate { get; set; }

        public void Copy(string from, string to)
        {
            Console.WriteLine($"{from} adresinden {to} adresine kopyalandı!");
        }

        public abstract void Save();
        public abstract void Load();




    }

    public interface IPrintable
    {
        void Print();

    }

    public class PdfDocument : Document
    {
        public override void Load()
        {
            Console.WriteLine("PDF Yüklendi");
        }



        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class ExcelDocument : Document, IPrintable, IComparable<ExcelDocument>, IEnumerable<int>
    {
        public int CompareTo(ExcelDocument? other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void Load()
        {
            Console.WriteLine("Excel Yüklendi");

        }

        public void Print()
        {

        }

        public override void Save()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Load()
        {
            Console.WriteLine("Word Yüklendi");

        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class DocumentPrintComponent
    {
        public void PrintDocument(IPrintable document)
        {
            document.Print();
        }
    }

    public class LoadDocumentComponent
    {
        public void LoadDoc(Document document)
        {
            document.Load();
        }
    }


}
