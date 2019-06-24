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

        bool isTrueRecord;
        bool isFalseRecord;
        bool onTrigger;

        DirectoryInfo dir;
        Thread thEmergency;

        public EmergencyProducer()
        {
            PathFolder = @"C://LH-1000\Properties";
            dir = new DirectoryInfo(PathFolder);
            if (!dir.Exists) dir.Create();
            dir = new DirectoryInfo(PathFolder);

            Status = "false";
            onTrigger = false;

            isTrueRecord = false;
            isFalseRecord = true;

            while(true)
            {
                try
                {
                    File.WriteAllText(PathFolder + "/emergency.txt", Status);
                    break;
                }
                catch
                {
                    Thread.Sleep(20);
                }
            }

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
                if (value == 1) return false;
                else return true;
            }
            else
            { return false; }
        }
        private void ThreadEmergency()
        {
            while(true)
            {
                if (onTrigger)
                {
                    if (!IsEmergency())
                    {
                        Status = "true";
                        while (true)
                        {
                            try
                            {
                                File.WriteAllText(PathFolder + "/emergency.txt", Status);
                                break;
                            }
                            catch
                            {
                                Thread.Sleep(20);
                            }
                        }
                        isTrueRecord = true;
                        isFalseRecord = false;
                    }
                }
                else
                {
                    if (!isFalseRecord)
                    {
                        Status = "false";
                        while (true)
                        {
                            try
                            {
                                File.WriteAllText(PathFolder + "/emergency.txt", Status);
                                break;
                            }
                            catch
                            {
                                Thread.Sleep(20);
                            }
                        }
                        isFalseRecord = true;
                        isTrueRecord = false;
                    }
                }

                Thread.Sleep(10);
            }
        }
        public void Trigger()
        {
            onTrigger = true;
        }
    }
}
