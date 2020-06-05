using System.ComponentModel;

namespace Tema3.Model
{
    class Categorie
    {
        private int categorieId;
        private string nume;

        public int CategorieId
        {
            get => categorieId;
            set
            {
                categorieId = value;
                OnPropertyChanged(nameof(CategorieId));
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