using System.Collections.ObjectModel;
using System.ComponentModel;
using Tema3.Model.BLL;

namespace Tema3.View_Model
{
    class MeniuriViewModel
    {

        private MeniuBLL menuBLL = new MeniuBLL();
        private ObservableCollection<Model.Meniu> meniuri;
        private Model.Meniu selectedMenu;
        private string isVisible;


        public static ObservableCollection<Model.Meniu> Oreders = new ObservableCollection<Model.Meniu>();
        public Model.Meniu SelectedMenu
        {
            get => selectedMenu;
            set
            {
                selectedMenu = value;
                OnPropertyChanged(nameof(Model.Meniu));
            }
        }

        public ObservableCollection<Model.Meniu> Meniuri
        {
            get => meniuri;
            set
            {
                meniuri = value;
                OnPropertyChanged(nameof(Meniuri));
            }
        }

        public string IsVisible
        {
            get => isVisible;
            set
            {
                isVisible = value;
                OnPropertyChanged(nameof(IsVisible));
            }
        }

        public MeniuriViewModel()
        {
            Meniuri = menuBLL.GetAllMenu();
            for (int i = 0; i < meniuri.Count; ++i)
            {
                Meniuri[i].Foods = menuBLL.GetAllProductsFromMenu(meniuri[i].MeniuId);
            }
            
        }


        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
