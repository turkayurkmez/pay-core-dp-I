// See https://aka.ms/new-console-template for more information
using Constructor;

Report salesReport = new Report("C:\\sales2022.xlsx");

Console.WriteLine("Hello, World!");
Console.WriteLine($"Raporun varsayılan formatı: {Enum.GetName(salesReport.Format)}");

Report performanceReport = new Report("C:\\HR2022.xlsx");
Report projectComplReport = new Report("C:\\deneme.xlsx", ReportFormat.Excel);