using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DataProduct
    {
        public DataTable SearchProduct(string search, EntityProductAttribute attribute, EntityOrderType orderType)
        {
            var productTable = new DataTable("Productos");

            try
            {
                using (SqlConnection connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntityProductAttribute.Id:
                            commandText = "sp_search_product_by_product_id";
                            break;
                        case EntityProductAttribute.Category:
                            commandText = "sp_search_product_by_category";
                            break;
                        case EntityProductAttribute.Name:
                            commandText = "sp_search_product_by_name";
                            break;
                        case EntityProductAttribute.Description:
                            commandText = "sp_search_product_by_description";
                            break;
                        case EntityProductAttribute.Price:
                            commandText = "sp_search_product_by_price";
                            break;
                        case EntityProductAttribute.Stock:
                            commandText = "sp_search_product_by_stock";
                            break;
                        case EntityProductAttribute.All:
                            commandText = "sp_search_product";
                            break;
                    }
                    if (orderType == EntityOrderType.DESC)
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
                    new SqlDataAdapter(command).Fill(productTable);
                }
            }
            catch
            {
                return productTable;
            }
            return productTable;
        }

        public byte[] SearchProductImage(int id)
        {
            byte[] image = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_search_product_image_by_id",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    var result = new DataTable("Image");
                    _ = new SqlDataAdapter(command).Fill(result);

                    if (result.Rows.Count > 0)
                    {
                        image = result.Rows[0]["foto"] is null ? null : result.Rows[0]["foto"] as byte[];
                    }
                }
            }
            catch
            {
                return image;
            }
            return image;
        }

        public int InsertProduct(EntityProduct product)
        {
            int rowsAffected = -1;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_product",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@category_id", SqlDbType.Int).Value = product.CategoryID;
                    command.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = product.Name;
                    command.Parameters.Add("@description", SqlDbType.Text).Value = product.Description;
                    command.Parameters.Add("@price", SqlDbType.Money).Value = product.Price;
                    command.Parameters.Add("@picture", SqlDbType.Image).Value = product.Image;

                    rowsAffected = command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch
            {
                return 0;
            }
            return rowsAffected;
        }

        public int EditProduct(EntityProduct product)
        {
            int rowsAffected = -1;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_product",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@product_id", SqlDbType.Int).Value = product.ProductID;
                    command.Parameters.Add("@category_id", SqlDbType.Int).Value = product.CategoryID;
                    command.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = product.Name;
                    command.Parameters.Add("@description", SqlDbType.Text).Value = product.Description;
                    command.Parameters.Add("@price", SqlDbType.Money).Value = product.Price;
                    command.Parameters.Add("@picture", SqlDbType.Image).Value = product.Image;

                    rowsAffected = command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch
            {
                return 0;
            }
            return rowsAffected;
        }

        public int DeleteProduct(EntityProduct product)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_product",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@id", SqlDbType.Int).Value = product.ProductID;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return 0;
            }

            return rowsAffected;
        }
    }
}
