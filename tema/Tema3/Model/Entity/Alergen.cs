using System.ComponentModel;

namespace Tema3.Model
{
    class Alergen
    {
        private int alergenId;
        private string nume;

        public int AlergenId
        {
            get => alergenId;
            set
            {
                alergenId = value;
                OnPropertyChanged(nameof(AlergenId));
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