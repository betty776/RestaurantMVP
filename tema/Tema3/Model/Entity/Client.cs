using System.ComponentModel;

namespace Tema3
{
    class Client
    {
        private int clientId;
        private string nume;
        private string prenume;
        private string adresa;
        private string nrTelefon;
        private string email;
        private string parola;

        public int ClientId
        {
            get => clientId;
            set
            {
                clientId = value;
                OnPropertyChanged(nameof(ClientId));
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


        public string Prenume
        {
            get => prenume;
            set
            {
                prenume = value;
                OnPropertyChanged(nameof(Prenume));
            }
        }


        public string Adresa
        {
            get => adresa;
            set
            {
                adresa = value;
                OnPropertyChanged(nameof(Adresa));
            }
        }

        public string Telefon
        {
            get => nrTelefon;
            set
            {
                nrTelefon = value;
                OnPropertyChanged(nameof(Telefon));
            }
        }
        public string Email
        {
            get => email;
            set
            {
                email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string Parola
        {
            get => parola;
            set
            {
                parola = value;
                OnPropertyChanged(nameof(Parola));
            }
        }

        public string Username { get; internal set; }

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
