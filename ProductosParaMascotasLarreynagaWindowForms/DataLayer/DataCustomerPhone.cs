using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityCustomerPhone;

namespace DataLayer
{
    public class DataCustomerPhone
    {
        public DataTable Select(string search, EntityCustomerPhoneAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Correo Cliente");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntityCustomerPhoneAttribute.PhoneId:
                            break;
                        case EntityCustomerPhoneAttribute.CustomerId:
                            commandText = "sp_search_customer_phone_by_customer_id";
                            break;
                        case EntityCustomerPhoneAttribute.Number:
                            break;
                        case EntityCustomerPhoneAttribute.All:
                            commandText = "sp_search_customer_phone";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntityCustomerPhoneAttribute.All)
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
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
            }
            catch
            {
                return data;
            }
            return data;
        }

        public int Insert(EntityCustomerPhone entity)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_customer_phone",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = entity.CustomerId;
                    command.Parameters.Add("@Number", SqlDbType.VarChar, 9).Value = entity.Number;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Update(EntityCustomerPhone entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_customer_phone",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@PhoneId", SqlDbType.Int).Value = entity.PhoneId;
                    command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = entity.CustomerId;
                    command.Parameters.Add("@Number", SqlDbType.VarChar, 9).Value = entity.Number;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Delete(EntityCustomerPhone entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_customer_phone",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@PhoneId", SqlDbType.Int).Value = entity.PhoneId;
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
