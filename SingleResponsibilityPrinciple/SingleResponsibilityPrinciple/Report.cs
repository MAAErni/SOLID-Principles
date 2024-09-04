using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Report
    {
        public string Content { get; set; }
    }

    public class ReportGenerator
    {
        public void GenerateReport(Report report, string content)
        {
            report.Content = content;
        }
    }

    public class ReportFormatter
    {
        public void FormatReport(Report report)
        {
            report.Content = report.Content.ToLower();
        }
    }

    public class ReportPersist
    {
        public void SaveToFile(Report report, string filename)
        {
            File.WriteAllText(filename, report.Content);
        }

        public void LoadFromFile(Report report, string filename)
        {
            report.Content = File.ReadAllText(filename);
        }
    }
}


