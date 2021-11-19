using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntitySupplierPhone;

namespace DataLayer
{
    public class DataSupplierPhone
    {
        public DataTable Select(string search, EntitySupplierPhoneAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Telefono Proveedor");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntitySupplierPhoneAttribute.PhoneId:
                            break;
                        case EntitySupplierPhoneAttribute.SupplierId:
                            break;
                        case EntitySupplierPhoneAttribute.PhoneNumber:
                            break;
                        case EntitySupplierPhoneAttribute.All:
                            commandText = "sp_search_supplier_phone";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntitySupplierPhoneAttribute.All)
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

        public int Insert(EntitySupplierPhone entity)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_supplier_phone",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@SupplierId", SqlDbType.Int).Value = entity.SupplierId;
                    command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 9).Value = entity.PhoneNumber;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Update(EntitySupplierPhone entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_supplier_phone",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@PhoneId", SqlDbType.Int).Value = entity.PhoneId;
                    command.Parameters.Add("@SupplierId", SqlDbType.Int).Value = entity.SupplierId;
                    command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 9).Value = entity.PhoneNumber;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Delete(EntitySupplierPhone entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_supplier_phone",
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
