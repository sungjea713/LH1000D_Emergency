using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LH1000D_Emergency.Windows
{
    /// <summary>
    /// WindowMain.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WindowMain : Window
    {
        public WindowMain()
        {
            InitializeComponent();

            System.Windows.Forms.NotifyIcon tray = new System.Windows.Forms.NotifyIcon();
            //tray.Icon = new System.Drawing.Icon("EMERGENCY_16.ico");
            //tray.Visible = true;

            this.WindowState = WindowState.Minimized;
        }
    }
}
