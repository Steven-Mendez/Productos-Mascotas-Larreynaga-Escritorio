using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntitySupplierDetail;

namespace DataLayer
{
    public class DataSupplierDetail
    {
        public DataTable Select(string search, EntitySupplierDetailAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Detalles Proveedor");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntitySupplierDetailAttribute.SupplierId:
                            break;
                        case EntitySupplierDetailAttribute.ProductId:
                            break;
                        case EntitySupplierDetailAttribute.Date:
                            break;
                        case EntitySupplierDetailAttribute.Quantity:
                            break;
                        case EntitySupplierDetailAttribute.PurchasePrice:
                            break;
                        case EntitySupplierDetailAttribute.All:
                            commandText = "sp_search_supplier_detail";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntitySupplierDetailAttribute.All)
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

        public int Insert(EntitySupplierDetail entity)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_supplier_detail",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@SupplierId", SqlDbType.Int).Value = entity.SupplierId;
                    command.Parameters.Add("@ProductId", SqlDbType.Int).Value = entity.ProductId;
                    command.Parameters.Add("@Date", SqlDbType.DateTime).Value = entity.Date;
                    command.Parameters.Add("@Quantity", SqlDbType.Int).Value = entity.Quantity;
                    command.Parameters.Add("@PurcharsePrice", SqlDbType.Money).Value = entity.PurcharsePrice;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Update(EntitySupplierDetail entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_supplier_detail",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@SupplierId", SqlDbType.Int).Value = entity.SupplierId;
                    command.Parameters.Add("@ProductId", SqlDbType.Int).Value = entity.ProductId;
                    command.Parameters.Add("@Date", SqlDbType.DateTime).Value = entity.Date;
                    command.Parameters.Add("@Quantity", SqlDbType.Int).Value = entity.Quantity;
                    command.Parameters.Add("@PurcharsePrice", SqlDbType.Money).Value = entity.PurcharsePrice;
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return rowsAffected;
            }
            return rowsAffected;
        }

        public int Delete(EntitySupplierDetail entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_supplier_detail",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@SupplierId", SqlDbType.Int).Value = entity.SupplierId;
                    command.Parameters.Add("@ProductId", SqlDbType.Int).Value = entity.ProductId;
                    command.Parameters.Add("@Date", SqlDbType.DateTime).Value = entity.Date;
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
