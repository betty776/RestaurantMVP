using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Tema3.Model;
using Tema3.Model.BLL;

namespace Tema3.View_Model
{
    class MeniuViewModel
    {
        private MeniuBLL menuBLL = new MeniuBLL();
        private ObservableCollection<Model.Meniu> meniuri;
        private Model.Meniu selectedMenu;
        private string available;


        public static ObservableCollection<Model.Meniu> CartMenus = new ObservableCollection<Model.Meniu>();
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
            get => available;
            set
            {
                available = value;
                OnPropertyChanged(nameof(IsVisible));
            }
        }

        public MeniuViewModel()
        {
            Meniuri = menuBLL.GetAllMenu();
            for (int i = 0; i < meniuri.Count; ++i)
            {
                Meniuri[i].Foods = menuBLL.GetAllProductsFromMenu(meniuri[i].MeniuId);
            }
            
        }


        public static ObservableCollection<Tuple<Produse, Categorie, Alergen>> CartItems { get; internal set; }

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
