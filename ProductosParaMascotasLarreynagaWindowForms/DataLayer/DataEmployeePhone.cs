using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityEmployeePhone;

namespace DataLayer
{
    public class DataEmployeePhone
    {
        public DataTable Select(string search, EntityEmployeePhoneAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Telefono Empleado");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntityEmployeePhoneAttribute.PhoneId:
                            break;
                        case EntityEmployeePhoneAttribute.EmployeeId:
                            commandText = "sp_search_employee_phone_by_employee_id";
                            break;
                        case EntityEmployeePhoneAttribute.Number:
                            break;
                        case EntityEmployeePhoneAttribute.All:
                            commandText = "sp_search_employee_phone";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntityEmployeePhoneAttribute.All)
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

        public int Insert(EntityEmployeePhone entity)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_employee_phone",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = entity.EmployeeId;
                    command.Parameters.Add("@Number", SqlDbType.VarChar, 200).Value = entity.Number;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Update(EntityEmployeePhone entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_employee_phone",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@PhoneId", SqlDbType.Int).Value = entity.PhoneId;
                    command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = entity.EmployeeId;
                    command.Parameters.Add("@Number", SqlDbType.VarChar, 200).Value = entity.Number;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Delete(EntityEmployeePhone entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_employee_phone",
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
