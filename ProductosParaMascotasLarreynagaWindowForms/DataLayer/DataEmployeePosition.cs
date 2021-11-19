using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityEmployeePosition;

namespace DataLayer
{
    public class DataEmployeePosition
    {
        public DataTable Select(string search, EntityEmployeePositionAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Cargo Empleado");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntityEmployeePositionAttribute.EmployeePositionId:
                            break;
                        case EntityEmployeePositionAttribute.Name:
                            break;
                        case EntityEmployeePositionAttribute.All:
                            commandText = "sp_search_employee_position";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntityEmployeePositionAttribute.All)
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

        public int Insert(EntityEmployeePosition entity)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_employee_position",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@Name", SqlDbType.Int).Value = entity.Name;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Update(EntityEmployeePosition entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_employee_position",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@EmployeePositionId", SqlDbType.Int).Value = entity.EmployeePositionId;
                    command.Parameters.Add("@Name", SqlDbType.Int).Value = entity.Name;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Delete(EntityEmployeePosition entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_employee_position",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@EmployeePositionId", SqlDbType.Int).Value = entity.EmployeePositionId;
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
