using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using LH1000D_Emergency.Ajin;
using System.Threading;

namespace LH1000D_Emergency.Model
{
    public class EmergencyProducer
    {
        public string PathFolder { get; set; }
        public string Status { get; set; }
        DirectoryInfo dir;
        Thread thEmergency;

        public EmergencyProducer()
        {
            PathFolder = @"C://LH-1000\Properties";
            dir = new DirectoryInfo(PathFolder);
            if (!dir.Exists) dir.Create();
            dir = new DirectoryInfo(PathFolder);

            Status = "false";

            File.WriteAllText(PathFolder + "/emergency.txt", Status);
            InitAjinModule();
            thEmergency = new Thread(new ThreadStart(ThreadEmergency));
            thEmergency.IsBackground = true;
            thEmergency.Start();
        }

        public void InitAjinModule()
        {
            CAXL.AxlOpen();
            
        }
        public bool IsEmergency()
        {
            if (CAXL.AxlIsOpened() == 1)
            {
                uint value = 0;
                CAXD.AxdiReadInportBit(0,0, ref value);
                if (value == 0) return false;
                else return true;
            }
            else
            { return false; }
        }
        private void ThreadEmergency()
        {
            while(true)
            {
                if(IsEmergency())
                {
                    Status = "true";
                    File.WriteAllText(PathFolder + "/emergency.txt", Status);
                }
                Thread.Sleep(10);
            }
        }
    }
}
