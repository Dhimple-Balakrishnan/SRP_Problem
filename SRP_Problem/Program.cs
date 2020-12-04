using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new SRP_Report();
            report.AddEntry(new WorkReportEntry { ProjectCode = "pro1", ProjectName = "SRP_Report", SpentHours = 2 });
            report.AddEntry(new WorkReportEntry { ProjectCode = "pro2", ProjectName = "OCP_Project", SpentHours = 1 });
            var save = new SavingFile();
            save.SaveToFile(report, "Myfiles", "Proect1.txt");
            Console.WriteLine(report.ToString());
            Console.ReadKey();
        }
    }
}
