using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityDepartment;

namespace DataLayer
{
    public class DataDepartment
    {
        public DataTable Select(string search, EntityDepartmentAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Departamento");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntityDepartmentAttribute.DepartmentId:
                            break;
                        case EntityDepartmentAttribute.Name:
                            break;
                        case EntityDepartmentAttribute.All:
                            commandText = "sp_search_deparment";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntityDepartmentAttribute.All)
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

        public int Insert(EntityDepartment entity)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_deparment",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@Name", SqlDbType.VarChar, 30).Value = entity.Name;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Update(EntityDepartment entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_deparment",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@DepartmentId", SqlDbType.Int).Value = entity.DepartmentId;
                    command.Parameters.Add("@Name", SqlDbType.VarChar, 30).Value = entity.Name;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Delete(EntityDepartment entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_deparment",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@DepartmentId", SqlDbType.Int).Value = entity.DepartmentId;
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
