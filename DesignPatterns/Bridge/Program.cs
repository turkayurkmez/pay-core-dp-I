// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * Problem: Alt kırılımlara doğru bir obje kimliği miras yoluyla özelleşmektedir. Her ihtiyaç için nu kırılıma devam etmek kaos oluşturur. Bu kaosu önlemek için ne yapmalısınız?
 */
SalesReport salesReport = new SalesReport();
salesReport.Format = new ExcelFormat();
salesReport.Format = new PdfFormat();


public class Report
{
    public ReportFormat Format { get; set; }
}

public class SalesReport : Report
{

}

public class PerformanceReport : Report
{

}

public class ReportFormat
{

}

public class PdfFormat : ReportFormat
{

}

public class ExcelFormat : ReportFormat
{

}