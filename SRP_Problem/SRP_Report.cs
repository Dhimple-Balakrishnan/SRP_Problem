using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Problem
{
    class SRP_Report
    {
        private readonly List<WorkReportEntry> _entries;
        public SRP_Report()
        {
            _entries = new List<WorkReportEntry>();
        }
        public void AddEntry(WorkReportEntry entry)
        {
            _entries.Add(entry);
        }
        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
        }
        
        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries.Select(x => $"Code: {x.ProjectCode}, Name:{x.ProjectName}, Hours: {x.SpentHours}"));

        }
    }
}
