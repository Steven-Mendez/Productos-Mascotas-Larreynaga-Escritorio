using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using static EntityLayer.EntityMunicipality;

namespace DataLayer
{
    public class DataMunicipality
    {
        public DataTable Select(string search, EntityMunicipalityAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Muninicipio");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntityMunicipalityAttribute.MunicipalityId:
                            break;
                        case EntityMunicipalityAttribute.DepartmentId:
                            break;
                        case EntityMunicipalityAttribute.Name:
                            break;
                        case EntityMunicipalityAttribute.All:
                            commandText = "sp_search_municipality";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntityMunicipalityAttribute.All)
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

        public int Insert(EntityMunicipality entity)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_municipality",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@DepartamentId", SqlDbType.Int).Value = entity.DepartamentId;
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

        public int Update(EntityMunicipality entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_municipality",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@MunicipalityId", SqlDbType.Int).Value = entity.MunicipalityId;
                    command.Parameters.Add("@DepartamentId", SqlDbType.Int).Value = entity.DepartamentId;
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

        public int Delete(EntityMunicipality entity)
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
                    command.Parameters.Add("@MunicipalityId", SqlDbType.Int).Value = entity.MunicipalityId;
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