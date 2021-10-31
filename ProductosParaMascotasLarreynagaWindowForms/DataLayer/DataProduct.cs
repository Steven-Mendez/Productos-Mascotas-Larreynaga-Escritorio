using EntityLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataProduct
    {
        public List<EntityProduct> SelectProduct(string search)
        {
            var productList = new List<EntityProduct>();
            using (var connection = new SqlConnection(DataConnection.ConnectionString))
            {
                var command = new SqlCommand()
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "sp_search_product",
                    Connection = connection
                };
                connection.Open();
                command.Parameters.Add("@search", SqlDbType.NVarChar, 1000).Value = search;
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        productList.Add(new EntityProduct()
                        {
                            ProductID = dataReader.GetInt32(0),
                            CategoryID = dataReader.GetInt32(1),
                            Name = dataReader.GetString(2),
                            Description = dataReader.GetString(3),
                            Price = dataReader.GetDecimal(4),
                            Stock = dataReader.GetInt32(5)
                        });
                    }
                }
            }
            return productList;
        }

        public int InsertProduct(EntityProduct product)
        {
            int rowsAffected = -1;
            using (var connection = new SqlConnection(DataConnection.ConnectionString))
            {
                var command = new SqlCommand()
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "sp_insert_product",
                    Connection = connection
                };
                command.Parameters.Add("@category_id", SqlDbType.Int).Value = product.CategoryID;
                command.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = product.Name;
                command.Parameters.Add("@description", SqlDbType.Text).Value = product.Description;
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            return rowsAffected;
        }

        public int EditProduct(EntityProduct product)
        {
            int rowsAffected = -1;
            using (var connection = new SqlConnection(DataConnection.ConnectionString))
            {
                var command = new SqlCommand()
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "sp_edit_product",
                    Connection = connection
                };
                command.Parameters.Add("@product_id", SqlDbType.Int).Value = product.ProductID;
                command.Parameters.Add("@category_id", SqlDbType.Int).Value = product.CategoryID;
                command.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = product.Name;
                command.Parameters.Add("@description", SqlDbType.Text).Value = product.Description;
                command.Parameters.Add("@price", SqlDbType.Money).Value = product.Price;

                rowsAffected = command.ExecuteNonQuery();
            }
            return rowsAffected;
        }
    }
}
