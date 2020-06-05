using System.Collections.ObjectModel;
using Tema3.Model.DAL;

namespace Tema3.Model.BLL
{
    class CommandBLL
    {
        ComandaDAL commandDAL = new ComandaDAL();

        internal void PlaseazaComanda(int discount, int clientId, decimal pretTotal, string data)
        {
            commandDAL.PlaseazaComanda(discount, clientId, pretTotal, data);
        }
        internal Comanda GetLastCommand()
        {
            return commandDAL.GetLastCommand();
        }

        internal void ComandaProdus(int produsId, int comandaId)
        {
            commandDAL.ComandaProdus(produsId, comandaId);
        }

        internal void ComandaMeniu(int meniuId, int comandaId)
        {
            commandDAL.ComandaMeniu(meniuId, comandaId);
        }
        internal ObservableCollection<Comanda> GetActiveCommands(int clientId)
        {
            return commandDAL.GetActiveCommands(clientId);
        }
    }
}
