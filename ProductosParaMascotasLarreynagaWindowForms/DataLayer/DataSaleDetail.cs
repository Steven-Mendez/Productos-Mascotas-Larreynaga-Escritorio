using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntitySaleDetail;

namespace DataLayer
{
    public class DataSaleDetail
    {
        public DataTable Select(string search, EntitySaleDetailAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Detalle Venta");
            try
            {
                using (SqlConnection connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntitySaleDetailAttribute.SaleId:
                            break;
                        case EntitySaleDetailAttribute.ProductId:
                            break;
                        case EntitySaleDetailAttribute.Price:
                            break;
                        case EntitySaleDetailAttribute.Quantity:
                            break;
                        case EntitySaleDetailAttribute.All:
                            commandText = "sp_search_sale_detail";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntitySaleDetailAttribute.All)
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
                    new SqlDataAdapter(command).Fill(data);
                }
            }
            catch
            {
                return data;
            }
            return data;
        }

        public int Insert(EntitySaleDetail entity)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_sale_detail",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@SaleId", SqlDbType.Int).Value = entity.SaleId;
                    command.Parameters.Add("@ProductId", SqlDbType.Int).Value = entity.ProductId;
                    command.Parameters.Add("@Price", SqlDbType.Money).Value = entity.Price;
                    command.Parameters.Add("@Quantity", SqlDbType.Int).Value = entity.Quantity;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Update(EntitySaleDetail entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_sale_detail",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@SaleId", SqlDbType.Int).Value = entity.SaleId;
                    command.Parameters.Add("@ProductId", SqlDbType.Int).Value = entity.ProductId;
                    command.Parameters.Add("@Price", SqlDbType.Money).Value = entity.Price;
                    command.Parameters.Add("@Quantity", SqlDbType.Int).Value = entity.Quantity;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Delete(EntitySaleDetail entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_sale_detail",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@SaleId", SqlDbType.Int).Value = entity.SaleId;
                    command.Parameters.Add("@ProductId", SqlDbType.Int).Value = entity.ProductId;
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
