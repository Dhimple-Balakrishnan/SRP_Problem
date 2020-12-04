using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SRP_Problem
{
    class SavingFile
    {
        //myawesomefeature goes here
        public void SaveToFile(SRP_Report report,string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.WriteAllText(Path.Combine(directoryPath, fileName), ToString());
        }
    }
}
