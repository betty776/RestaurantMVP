using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;


namespace Tema3.Model.DAL
{
    class MeniuDAL
    {
        internal ObservableCollection<Meniu> GetAllMenu()
        {
            SqlConnection connection = HelpDAL.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("spGetAllMenu", connection);
                ObservableCollection<Meniu> result = new ObservableCollection<Meniu>();
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Meniu m = new Meniu();
                    m.MeniuId = reader.GetInt32(0);
                    m.Nume = reader.GetString(1);
                    m.Discount = reader.GetInt32(2);
                    m.Pret = reader.GetDecimal(3);
                    result.Add(m);
                }
                reader.Close();
                return result;
            }
            finally
            {
                connection.Close();
            }
        }

        internal ObservableCollection<Produse> GetAllProductsFromMenu(int meniuId)
        {
            SqlConnection connection = HelpDAL.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("spGetProductsfromMenu", connection);
                ObservableCollection<Produse> result = new ObservableCollection<Produse>();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@meniuId", meniuId);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Produse f = new Produse();
                    f.Nume = reader.GetString(0);
                    result.Add(f);
                }
                reader.Close();
                return result;
            }
            finally
            {
                connection.Close();
            }
        }



    }
}

