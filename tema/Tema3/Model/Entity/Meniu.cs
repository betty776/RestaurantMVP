using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Tema3.Model
{
    class Meniu
    {
        private int meniuId;
        private string nume;
        private int discount;
        private decimal pret;
       private ObservableCollection<Produse> foods;

        public int MeniuId
        {
            get => meniuId;
            set
            {
                meniuId = value;
                OnPropertyChanged(nameof(MeniuId));
            }
        }
        public string Nume
        {
            get => nume;
            set
            {
                nume = value;
                OnPropertyChanged(nameof(Nume));
            }
        }

        public int Discount
        {
            get => discount;
            set
            {
                discount = value;
                OnPropertyChanged(nameof(Discount));
            }
        }

        public ObservableCollection<Produse> Foods
        {
            get => foods;
            set
            {
                foods = value;
                OnPropertyChanged(nameof(Foods));
            }

        }

        public decimal Pret
        {
            get => pret;
            set
            {
                pret = value;
                OnPropertyChanged(nameof(Pret));
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
    }
}
