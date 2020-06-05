using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace Tema3.Model.DAL
{
    class ProduseDAL
    {
        internal ObservableCollection<Tuple<Produse, Categorie, Alergen>> GetAllProducts()
        {
            SqlConnection connection = HelpDAL.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("spGetAllProducts", connection);
                ObservableCollection<Tuple<Produse, Categorie, Alergen>> result =
                    new ObservableCollection<Tuple<Produse, Categorie, Alergen>>();
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Produse product = new Produse();
                    Categorie category = new Categorie();
                    Alergen allergen = new Alergen();
                   
                    product.ProdusId = reader.GetInt32(0);
                    product.Nume = reader.GetString(1);
                    product.Pret = reader.GetDecimal(2);
                    product.Gramaj = reader.GetInt32(3);
                    category.Nume = reader.GetString(4);
                    allergen.Nume = reader.GetString(5);
                   
                    result.Add(new Tuple<Produse, Categorie, Alergen>(product, category, allergen));
                }
                reader.Close();
                return result;
            }
            finally
            {
                connection.Close();
            }
        }

        internal ObservableCollection<Tuple<Produse, Categorie, Alergen>> GetAllProductByPattern(string pattern)
        {
            SqlConnection connection = HelpDAL.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("spGetAllByPattern", connection);
                ObservableCollection<Tuple<Produse, Categorie, Alergen>> result =
                    new ObservableCollection<Tuple<Produse, Categorie, Alergen>>();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pattern", pattern);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Produse product = new Produse();
                    Categorie category = new Categorie();
                    Alergen allergen = new Alergen();
                   
                    product.ProdusId = reader.GetInt32(0);
                    product.Nume = reader.GetString(1);
                    product.Pret = reader.GetDecimal(2);
                    product.Cantitate = reader.GetInt32(3);
                    category.Nume = reader.GetString(4);
                    allergen.Nume = reader.GetString(5);
                   
                    result.Add(new Tuple<Produse, Categorie, Alergen>(product, category, allergen));
                }
                reader.Close();
                return result;
            }
            finally
            {
                connection.Close();
            }
        }

        internal ObservableCollection<Tuple<Produse, Categorie, Alergen>> GetAllProductByCategory(string category)
        {
            SqlConnection connection = HelpDAL.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("spGetAllByCategory", connection);
                ObservableCollection<Tuple<Produse, Categorie, Alergen>> result =
                    new ObservableCollection<Tuple<Produse, Categorie, Alergen>>();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@category", category);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Produse product = new Produse();
                    Categorie categorie
                        = new Categorie();
                    Alergen allergen = new Alergen();
                    
                    product.ProdusId = reader.GetInt32(0);
                    product.Nume = reader.GetString(1);
                    product.Pret = reader.GetDecimal(2);
                    product.Cantitate = reader.GetInt32(3);
                    categorie.Nume = reader.GetString(4);
                    allergen.Nume = reader.GetString(5);
                    result.Add(new Tuple<Produse, Categorie, Alergen>(product, categorie, allergen));
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