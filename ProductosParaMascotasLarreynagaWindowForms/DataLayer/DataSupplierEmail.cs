using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntitySupplierEmail;

namespace DataLayer
{
    public class DataSupplierEmail
    {
        public DataTable Select(string search, EntitySupplierEmailAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Correo Proveedor");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntitySupplierEmailAttribute.EmailId:
                            break;
                        case EntitySupplierEmailAttribute.SupplierId:
                            break;
                        case EntitySupplierEmailAttribute.Email:
                            break;
                        case EntitySupplierEmailAttribute.All:
                            commandText = "sp_search_supplier_email";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntitySupplierEmailAttribute.All)
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
                    command.Parameters.Add("@search", SqlDbType.VarChar, 1000).Value = search;
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

        public int Insert(EntitySupplierEmail entity)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_supplier_email",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@SupplierId", SqlDbType.Int).Value = entity.SupplierId;
                    command.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = entity.Email;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Update(EntitySupplierEmail entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_supplier_email",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@EmailId", SqlDbType.Int).Value = entity.EmailId;
                    command.Parameters.Add("@SupplierId", SqlDbType.Int).Value = entity.SupplierId;
                    command.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = entity.Email;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Delete(EntitySupplierEmail entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_supplier_email",
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
