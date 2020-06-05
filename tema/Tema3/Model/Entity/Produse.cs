using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3.Model
{
    class Produse
    {
    private int produsId;
    private string nume;
    private decimal pret;
    private int cantitate;
    private int gramaj;
    private int categorieId;
    private int activ;

       

        public int ProdusId
    {
        get => produsId;
        set
        {
            produsId = value;
            OnPropertyChanged(nameof(ProdusId));
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

    public decimal Pret
    {
        get => pret;
        set
        {
            pret = value;
            OnPropertyChanged(nameof(Pret));
        }
    }

    public int Cantitate
    {
        get => cantitate;
        set
        {
            cantitate = value;
            OnPropertyChanged(nameof(Cantitate));
        }
    }

    public int Gramaj
    {
        get => gramaj;
        set
        {
            gramaj = value;
            OnPropertyChanged(nameof(Gramaj));
        }
    }

    public int CategorieId
    {
        get => categorieId;
        set
        {
            categorieId = value;
            OnPropertyChanged(nameof(CategorieId));
        }
    }

    public int Activ
    {
        get => activ;
        set
        {
            activ = value;
            OnPropertyChanged(nameof(Activ));
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
