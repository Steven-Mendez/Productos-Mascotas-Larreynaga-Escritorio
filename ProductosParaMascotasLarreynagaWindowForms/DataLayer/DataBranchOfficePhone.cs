using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityBranchOfficePhone;

namespace DataLayer
{
    public class DataBranchOfficePhone
    {
        public DataTable Select(string search, EntityBranchOfficePhoneAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Telefono Sucursal");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntityBranchOfficePhoneAttribute.PhoneId:
                            break;
                        case EntityBranchOfficePhoneAttribute.BranchOfficeId:
                            break;
                        case EntityBranchOfficePhoneAttribute.PhoneNumber:
                            break;
                        case EntityBranchOfficePhoneAttribute.All:
                            commandText = "sp_search_branch_office_phone";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntityBranchOfficePhoneAttribute.All)
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

        public int Insert(EntityBranchOfficePhone branchOfficePhone)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_branch_office_phone",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@BranchOfficeId", SqlDbType.Int).Value = branchOfficePhone.BranchOfficeId;
                    command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 9).Value = branchOfficePhone.PhoneNumber;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Update(EntityBranchOfficePhone branchOfficePhone)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_branch_office_phone",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@BranchOfficePhoneId", SqlDbType.Int).Value = branchOfficePhone.PhoneId;
                    command.Parameters.Add("@BranchOfficeId", SqlDbType.Int).Value = branchOfficePhone.BranchOfficeId;
                    command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 9).Value = branchOfficePhone.PhoneNumber;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Delete(EntityBranchOfficePhone branchOfficePhone)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_branch_office_phone",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@BranchOfficePhoneId", SqlDbType.Int).Value = branchOfficePhone.PhoneId;
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
