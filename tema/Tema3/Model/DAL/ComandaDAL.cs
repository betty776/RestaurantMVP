using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace Tema3.Model.DAL
{
    class ComandaDAL
    {
        internal ObservableCollection<Comanda> GetActiveCommands(int clientId)
        {
            SqlConnection connection = HelpDAL.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("spGetActiveCommand", connection);
                connection.Open(); cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clientId", clientId);
                ObservableCollection<Comanda> result = new ObservableCollection<Comanda>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Comanda c = new Comanda();
                    c.Data = DateTime.Parse(reader.GetString(0));
                    c.ComandaId = reader.GetInt32(1);
                    c.PretTotal = reader.GetDecimal(2);
                    result.Add(c);
                }
                reader.Close();
                return result;
            }
            finally
            {
                connection.Close();
            }
        }

        internal void ComandaProdus(int produsId, int comandaId)
        {
            SqlConnection connection = HelpDAL.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("spAddProductsCommand", connection);
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@produsId", produsId);
                cmd.Parameters.AddWithValue("@idCommand", comandaId);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        internal void ComandaMeniu(int meniuId, int comandaId)
        {
            SqlConnection connection = HelpDAL.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("spAddMenuCommand", connection);
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMenu", meniuId);
                cmd.Parameters.AddWithValue("@idCommand", comandaId);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }


        internal void PlaseazaComanda(int discount, int clientId, decimal pretTotal, string data)
        {
            SqlConnection connection = HelpDAL.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("spCommand", connection);
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@discount", discount);
                cmd.Parameters.AddWithValue("@clientId", clientId);
                cmd.Parameters.AddWithValue("@pretTotal", pretTotal);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        internal Comanda GetLastCommand()
        {
            SqlConnection connection = HelpDAL.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("spGetLastCommand", connection);
                connection.Open();
                Comanda result = new Comanda();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.ComandaId = reader.GetInt32(0);
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