using System.Collections.ObjectModel;
using Tema3.Model.DAL;


namespace Tema3.Model.BLL
{
    class MeniuBLL
    {
        MeniuDAL meniuDAL = new MeniuDAL();
        internal ObservableCollection<Meniu> GetAllMenu()
        {
            return meniuDAL.GetAllMenu();
        }

        internal ObservableCollection<Produse> GetAllProductsFromMenu(int MeniuId)
        {
            return meniuDAL.GetAllProductsFromMenu(MeniuId);
        }

    }
}