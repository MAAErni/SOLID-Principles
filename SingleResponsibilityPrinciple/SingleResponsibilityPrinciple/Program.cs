using System;
using SingleResponsibilityPrinciple;

class Program
{
    static void Main(string[] args)
    {
        Report report = new Report();
        ReportGenerator generator = new ReportGenerator();
        ReportFormatter formatter = new ReportFormatter();
        ReportPersist persist = new ReportPersist();

        generator.GenerateReport(report, "This is some content.");
        formatter.FormatReport(report);
        persist.SaveToFile(report, "report.txt");
        persist.LoadFromFile(report, "report.txt");

        Console.WriteLine(report.Content);
    }
}


