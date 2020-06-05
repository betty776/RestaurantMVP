using System.Configuration;
using System.Data.SqlClient;

namespace Tema3.Model.DAL
{
    internal class HelpDAL
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;

        internal static SqlConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }
    }
}