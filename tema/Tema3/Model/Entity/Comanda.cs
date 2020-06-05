using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3.Model
{
    class Comanda
    {
        private int comandaId;
        private int discount;
        private int statusId;
        private int clientId;
        private decimal pretTotal;
        private DateTime data;

        public DateTime Data
        {
            get => data;
            set
            {
                data = value;
                OnPropertyChanged(nameof(Data));
            }
        }

       

        public int ComandaId
        {
            get => comandaId;
            set
            {
                comandaId = value;
                OnPropertyChanged(nameof(ComandaId));
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

        public int StatusId
        {
            get => statusId;
            set
            {
                statusId = value;
                OnPropertyChanged(nameof(StatusId));
            }
        }

        public int ClientId
        {
            get => clientId;
            set
            {
                clientId = value;
                OnPropertyChanged(nameof(ClientId));
            }
        }

        public decimal PretTotal
        {
            get => pretTotal;
            set
            {
                pretTotal = value;
                OnPropertyChanged(nameof(PretTotal));
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