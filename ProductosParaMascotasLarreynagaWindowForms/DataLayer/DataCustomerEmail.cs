using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityCustomerEmail;

namespace DataLayer
{
    public class DataCustomerEmail
    {
        public DataTable Select(string search, EntityCustomerEmailAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Correo Cliente");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntityCustomerEmailAttribute.EmailId:
                            break;
                        case EntityCustomerEmailAttribute.CustomerId:
                            break;
                        case EntityCustomerEmailAttribute.Email:
                            break;
                        case EntityCustomerEmailAttribute.All:
                            commandText = "sp_search_customer_email";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntityCustomerEmailAttribute.All)
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

        public int Insert(EntityCustomerEmail entity)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_customer_email",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = entity.CustomerId;
                    command.Parameters.Add("@Email", SqlDbType.VarChar, 200).Value = entity.Email;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Update(EntityCustomerEmail entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_customer_email",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@EmailId", SqlDbType.Int).Value = entity.EmailId;
                    command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = entity.CustomerId;
                    command.Parameters.Add("@Email", SqlDbType.VarChar, 200).Value = entity.Email;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Delete(EntityCustomerEmail entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_customer_email",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@EmailId", SqlDbType.Int).Value = entity.EmailId;
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