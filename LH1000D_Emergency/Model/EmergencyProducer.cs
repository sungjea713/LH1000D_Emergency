using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace LH1000D_Emergency.Model
{
    public class EmergencyProducer
    {
        public string PathFolder { get; set; }
        public string Status { get; set; }
        DirectoryInfo dir;

        public EmergencyProducer()
        {
            PathFolder = @"C://LH-1000\Properties";
            dir = new DirectoryInfo(PathFolder);
            if (!dir.Exists) dir.Create();
            dir = new DirectoryInfo(PathFolder);

            Status = "false";

            File.WriteAllText(PathFolder + "/emergency.txt", Status);
        }
    }
}
