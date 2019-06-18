using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LH1000D_Emergency.MVVM;
using LH1000D_Emergency.Model;
using System.Windows.Input; //For ICommand
using System.Collections.ObjectModel; //For ObservableObject

namespace LH1000D_Emergency.ViewModel
{
    class ViewModelMain : ObservableObject
    {
        EmergencyProducer emg = new EmergencyProducer();

        public ViewModelMain()
        {

        }
    }
}
