namespace Constructor
{
    public enum ReportFormat
    {
        PDF,
        Excel
    }
    public class Report
    {
        //Bu sınıftan türeyen nesne; bir excel dosyasından veriyi okur ve belirtilen formatta rapor oluşturur.
        public Report()
        {
            Format = ReportFormat.PDF;
        }
        public Report(string filePath)
        {
            FilePath = filePath;
        }

        public ReportFormat Format { get; set; }
        public string FilePath { get; set; }

    }
}
