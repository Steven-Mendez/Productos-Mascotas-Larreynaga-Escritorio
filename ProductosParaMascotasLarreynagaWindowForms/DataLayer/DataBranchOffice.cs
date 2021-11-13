using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using static EntityLayer.EntityBranchOffice;

namespace DataLayer
{
    public class DataBranchOffice
    {
        public DataTable Select(string search, EntityBranchOfficeAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Sucursal");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntityBranchOfficeAttribute.BranchOfficeId:
                            commandText = "sp_search_branch_office_by_branch_office_id";
                            break;
                        case EntityBranchOfficeAttribute.Name:
                            commandText = "sp_search_branch_office_by_name";
                            break;
                        case EntityBranchOfficeAttribute.Address:
                            commandText = "sp_search_branch_office_by_address";
                            break;
                        case EntityBranchOfficeAttribute.All:
                            commandText = "sp_search_branch_office";
                            break;
                        default:
                            commandText = "sp_search_branch_office";
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntityBranchOfficeAttribute.All)
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

        public int Insert(EntityBranchOffice branchOffice)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_branch_office",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@MunicipalityId", SqlDbType.Int).Value = branchOffice.MunicipalityId;
                    command.Parameters.Add("@Name", SqlDbType.VarChar, 70).Value = branchOffice.Name;
                    command.Parameters.Add("@Address", SqlDbType.VarChar, 200).Value = branchOffice.Address;
                    command.Parameters.Add("@StreetNumber", SqlDbType.Int).Value = branchOffice.StreetNumber;
                    command.Parameters.Add("@StreetName", SqlDbType.VarChar, 50).Value = branchOffice.StreetName;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Update(EntityBranchOffice branchOffice)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_branch_office",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@BranchOfficeId", SqlDbType.Int).Value = branchOffice.BranchOfficeId;
                    command.Parameters.Add("@MunicipalityId", SqlDbType.Int).Value = branchOffice.MunicipalityId;
                    command.Parameters.Add("@Name", SqlDbType.VarChar, 70).Value = branchOffice.Name;
                    command.Parameters.Add("@Address", SqlDbType.VarChar, 200).Value = branchOffice.Address;
                    command.Parameters.Add("@StreetNumber", SqlDbType.Int).Value = branchOffice.StreetNumber;
                    command.Parameters.Add("@StreetName", SqlDbType.VarChar, 50).Value = branchOffice.StreetName;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Delete(EntityBranchOffice branchOffice)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_branch_office",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@BranchOfficeId", SqlDbType.Int).Value = branchOffice.BranchOfficeId;
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
