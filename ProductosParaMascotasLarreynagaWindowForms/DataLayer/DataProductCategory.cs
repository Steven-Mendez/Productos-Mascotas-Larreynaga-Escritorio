using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataProductCategory
    {
        public DataTable SearchProductCategory(string search, EntityProductCategoryAttribute attribute, EntityOrderType orderType)
        {
            var productCategoryTable = new DataTable("Categorias de Producto");
            try
            {
                using (SqlConnection connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntityProductCategoryAttribute.CategoryID:
                            commandText = "sp_search_product_category_by_category_id";
                            break;
                        case EntityProductCategoryAttribute.Name:
                            commandText = "sp_search_product_category_by_category_name";
                            break;
                        case EntityProductCategoryAttribute.All:
                            commandText = "sp_search_product_category";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntityProductCategoryAttribute.All)
                    {
                        commandText += "_desc";
                    }
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = commandText,
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@search", SqlDbType.NVarChar, 1000).Value = search;
                    new SqlDataAdapter(command).Fill(productCategoryTable);
                }
            }
            catch (Exception e)
            {
                throw e;
                //return productCategoryTable;
            }
            return productCategoryTable;
        }

        public int InsertProductCategory(EntityProductCategory category)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_product_categoy",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@Name", SqlDbType.VarChar, 30).Value = category.Name;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int EditProductCategory(EntityProductCategory category)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_product_categoy",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = category.CategoryID;
                    command.Parameters.Add("@Name", SqlDbType.VarChar, 30).Value = category.Name;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int DeleteProductCategory(EntityProductCategory category)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_product_categoy",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = category.CategoryID;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }
    }
}
