using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityEmployeeEmail;

namespace DataLayer
{
    public class DataEmployeeEmail
    {
        public DataTable Select(string search, EntityEmployeeEmailAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Correo Empleado");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntityEmployeeEmailAttribute.EmailId:
                            break;
                        case EntityEmployeeEmailAttribute.EmployeeId:
                            break;
                        case EntityEmployeeEmailAttribute.Email:
                            break;
                        case EntityEmployeeEmailAttribute.All:
                            commandText = "sp_search_employee_email";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntityEmployeeEmailAttribute.All)
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

        public int Insert(EntityEmployeeEmail entity)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_employee_email",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = entity.EmployeeId;
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

        public int Update(EntityEmployeeEmail entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_employee_email",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@EmailId", SqlDbType.Int).Value = entity.EmailId;
                    command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = entity.EmployeeId;
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

        public int Delete(EntityEmployeeEmail entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_employee_email",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = entity.EmployeeId;
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
