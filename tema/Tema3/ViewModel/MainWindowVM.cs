using Microsoft.TeamFoundation.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3.ViewModel
{
    class MainWindowVM : BaseViewModel
    {
        public BaseViewModel activeScreen;//= new WelcomeViewModel();

        public BaseViewModel ActiveScreen
        {
            get { return activeScreen; }


            set
            {
                activeScreen = value;
                OnPropertyChanged(nameof(ActiveScreen));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }

        }
        public MainWindowVM()
        {
            Instance = this;

        }
        public static MainWindowVM Instance { get; private set; }

    }
  

}
