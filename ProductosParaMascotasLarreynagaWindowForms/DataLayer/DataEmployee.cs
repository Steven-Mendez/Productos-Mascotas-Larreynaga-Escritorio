using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityEmployee;

namespace DataLayer
{
    public class DataEmployee
    {
        public DataTable Select(string search, EntityEmployeeAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Empleado");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntityEmployeeAttribute.EmployeeId:
                            break;
                        case EntityEmployeeAttribute.EmployeePositionId:
                            break;
                        case EntityEmployeeAttribute.BranchOfficeId:
                            break;
                        case EntityEmployeeAttribute.MunicipalityId:
                            break;
                        case EntityEmployeeAttribute.FirstName:
                            break;
                        case EntityEmployeeAttribute.SecondName:
                            break;
                        case EntityEmployeeAttribute.FirstSurname:
                            break;
                        case EntityEmployeeAttribute.SecondSurname:
                            break;
                        case EntityEmployeeAttribute.Identification:
                            break;
                        case EntityEmployeeAttribute.Address:
                            break;
                        case EntityEmployeeAttribute.StreetNumber:
                            break;
                        case EntityEmployeeAttribute.StreetName:
                            break;
                        case EntityEmployeeAttribute.All:
                            commandText = "sp_search_employee";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntityEmployeeAttribute.All)
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

        public int Insert(EntityEmployee entity)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_employee",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@EmployeePositionId", SqlDbType.Int).Value = entity.EmployeePositionId;
                    command.Parameters.Add("@BranchOfficeId", SqlDbType.Int).Value = entity.BranchOfficeId;
                    command.Parameters.Add("@MunicipalityId", SqlDbType.Int).Value = entity.MunicipalityId;
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = entity.FirstName;
                    command.Parameters.Add("@SecondName", SqlDbType.VarChar, 50).Value = entity.SecondName;
                    command.Parameters.Add("@FirstSurname", SqlDbType.VarChar, 50).Value = entity.FirstSurname;
                    command.Parameters.Add("@SecondSurname", SqlDbType.VarChar, 50).Value = entity.SecondSurname;
                    command.Parameters.Add("@Identification", SqlDbType.VarChar, 16).Value = entity.Identification;
                    command.Parameters.Add("@Address", SqlDbType.VarChar, 200).Value = entity.Address;
                    command.Parameters.Add("@StreetNumber", SqlDbType.Int).Value = entity.StreetNumber;
                    command.Parameters.Add("@StreetName", SqlDbType.VarChar, 50).Value = entity.StreetName;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Update(EntityEmployee entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_employee",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = entity.EmployeeId;
                    command.Parameters.Add("@EmployeePositionId", SqlDbType.Int).Value = entity.EmployeePositionId;
                    command.Parameters.Add("@BranchOfficeId", SqlDbType.Int).Value = entity.BranchOfficeId;
                    command.Parameters.Add("@MunicipalityId", SqlDbType.Int).Value = entity.MunicipalityId;
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = entity.FirstName;
                    command.Parameters.Add("@SecondName", SqlDbType.VarChar, 50).Value = entity.SecondName;
                    command.Parameters.Add("@FirstSurname", SqlDbType.VarChar, 50).Value = entity.FirstSurname;
                    command.Parameters.Add("@SecondSurname", SqlDbType.VarChar, 50).Value = entity.SecondSurname;
                    command.Parameters.Add("@Identification", SqlDbType.VarChar, 16).Value = entity.Identification;
                    command.Parameters.Add("@Address", SqlDbType.VarChar, 200).Value = entity.Address;
                    command.Parameters.Add("@StreetNumber", SqlDbType.Int).Value = entity.StreetNumber;
                    command.Parameters.Add("@StreetName", SqlDbType.VarChar, 50).Value = entity.StreetName;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Delete(EntityEmployee entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_employee",
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

        public DataTable SelectEngine(string search)
        {
            var data = new DataTable("Empleado");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = "sp_select_employee";

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
    }
}
