using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntitySale;

namespace DataLayer
{
    public class DataSale
    {
        public DataTable Select(string search, EntitySaleAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Venta");
            try
            {
                using (SqlConnection connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntitySaleAttribute.SaleId:
                            break;
                        case EntitySaleAttribute.CustomerId:
                            break;
                        case EntitySaleAttribute.EmployeeId:
                            break;
                        case EntitySaleAttribute.Date:
                            break;
                        case EntitySaleAttribute.All:
                            commandText = "sp_search_sale";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntitySaleAttribute.All)
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

        public int Insert(EntitySale entity)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_sale",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = entity.CustomerId;
                    command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = entity.EmployeeId;
                    command.Parameters.Add("@Date", SqlDbType.VarChar, 30).Value = entity.Date;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Update(EntitySale entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_sale",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@SaleId", SqlDbType.Int).Value = entity.SaleId;
                    command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = entity.CustomerId;
                    command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = entity.EmployeeId;
                    command.Parameters.Add("@Date", SqlDbType.VarChar, 30).Value = entity.Date;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Delete(EntitySale entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_sale",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@SaleId", SqlDbType.Int).Value = entity.SaleId;
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
