using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3.Model
{
    class Angajati
    {
        private int angajatId;
        private string nume;
        private string prenume;
        private string adresa;
        private string nrTelefon;
        private string email;
        private string parola;

        public int AngajatId
        {
            get => angajatId;
            set
            {
                angajatId = value;
                OnPropertyChanged(nameof(AngajatId));
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
