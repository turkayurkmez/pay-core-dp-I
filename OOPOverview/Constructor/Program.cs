// See https://aka.ms/new-console-template for more information
using Constructor;

Report salesReport = new Report();

Console.WriteLine("Hello, World!");
Console.WriteLine($"Raporun varsayılan formatı: {Enum.GetName(salesReport.Format)}");