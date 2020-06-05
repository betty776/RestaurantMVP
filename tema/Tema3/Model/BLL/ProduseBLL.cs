using System;
using System.Collections.ObjectModel;
using Tema3.Model.DAL;

namespace Tema3.Model.BLL
{
    class ProduseBLL
    {

        ProduseDAL productDAL = new ProduseDAL();

        internal ObservableCollection<Tuple<Produse, Categorie, Alergen>> GetAllProducts()
        {
            return productDAL.GetAllProducts();
        }

        internal ObservableCollection<Tuple<Produse, Categorie, Alergen>> GetAllProductByPattern(string pattern)
        {
            return productDAL.GetAllProductByPattern(pattern);
        }

        internal ObservableCollection<Tuple<Produse, Categorie, Alergen>> GetAllProductByCategory(string category)
        {
            return productDAL.GetAllProductByCategory(category);
        }
    }
}
