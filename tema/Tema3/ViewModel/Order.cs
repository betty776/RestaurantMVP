using Tema3.Model.BLL;
using System;
using System.Collections.ObjectModel;
using Tema3.Model;
using System.ComponentModel;


namespace Tema3.View_Model
{
    class Order
    {
        private ObservableCollection<Tuple<Produse, Categorie, Alergen>> cosCumparaturi;
        private ObservableCollection<Model.Meniu> cartMenus;
        private Tuple<Produse, Categorie, Alergen> selectedItem;
        private Model.Meniu selectedMenu;
        private decimal pretTotal;
        private CommandBLL comandaBLL = new CommandBLL();

        public Model.Meniu SelectedMenu
        {
            get => selectedMenu;
            set
            {
                selectedMenu = value;
                OnPropertyChanged(nameof(SelectedMenu));
            }
        }

        public ObservableCollection<Model.Meniu> CartMenus
        {
            get => cartMenus;
            set
            {
                cartMenus = value;
                OnPropertyChanged(nameof(CartMenus));
            }
        }

        public ObservableCollection<Tuple<Produse, Categorie, Alergen>> CartItems
        {
            get => cosCumparaturi;
            set
            {
                cosCumparaturi = value;
                OnPropertyChanged(nameof(CartItems));
            }
        }

        public Tuple<Produse, Categorie, Alergen> SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }

        public decimal TotalPrice
        {
            get => pretTotal;
            set
            {
                pretTotal = value;
                OnPropertyChanged(nameof(TotalPrice));
            }
        }
        public Order()
        {
            CartItems = MeniuViewModel.CartItems;
            CartMenus = MeniuriViewModel.Oreders;
            for (int i = 0; i < CartItems.Count; ++i)
            {
                TotalPrice += CartItems[i].Item1.Pret;
            }
            for (int i = 0; i < CartMenus.Count; ++i)
            {
                TotalPrice += CartMenus[i].Pret;
            }

        }

        public object ComandaBLL { get; private set; }

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
