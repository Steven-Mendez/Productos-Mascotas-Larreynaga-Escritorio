using EntityLayer;
using System.Data;
using System.Data.SqlClient;
using static EntityLayer.EntityCustomer;

namespace DataLayer
{
    public class DataCustomer
    {
        public DataTable Select(string search, EntityCustomerAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Cliente");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntityCustomerAttribute.CustomerId:
                            break;
                        case EntityCustomerAttribute.MunicipalityId:
                            break;
                        case EntityCustomerAttribute.FirstName:
                            break;
                        case EntityCustomerAttribute.SecondName:
                            break;
                        case EntityCustomerAttribute.Identification:
                            break;
                        case EntityCustomerAttribute.Address:
                            break;
                        case EntityCustomerAttribute.StreetNumber:
                            break;
                        case EntityCustomerAttribute.StreetName:
                            break;
                        case EntityCustomerAttribute.All:
                            commandText = "sp_search_customer";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntityCustomerAttribute.All)
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

        public int Insert(EntityCustomer entity)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_customer",
                        Connection = connection
                    };
                    connection.Open();
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

        public int Update(EntityCustomer entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_customer",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = entity.CustomerId;
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

        public int Delete(EntityCustomer entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_customer",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = entity.CustomerId;
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
            var data = new DataTable("Cliente");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = "sp_select_customer";
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
