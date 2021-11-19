﻿using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntitySupplier;

namespace DataLayer
{
    public class DataSupplier
    {
        public DataTable Select(string search, EntitySupplierAttribute attribute, EntityOrderType orderType)
        {
            var data = new DataTable("Proveedores");
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    string commandText = null;
                    switch (attribute)
                    {
                        case EntitySupplierAttribute.SupplierId:
                            break;
                        case EntitySupplierAttribute.MunicipalityId:
                            break;
                        case EntitySupplierAttribute.Name:
                            break;
                        case EntitySupplierAttribute.Address:
                            break;
                        case EntitySupplierAttribute.StreetNumber:
                            break;
                        case EntitySupplierAttribute.StreetName:
                            break;
                        case EntitySupplierAttribute.All:
                            commandText = "sp_search_supplier";
                            break;
                        default:
                            break;
                    }
                    if (orderType == EntityOrderType.DESC && attribute != EntitySupplierAttribute.All)
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

        public int Insert(EntitySupplier entity)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_insert_supplier",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@MunicipalityId", SqlDbType.Int).Value = entity.MunicipalityId;
                    command.Parameters.Add("@Name", SqlDbType.VarChar, 70).Value = entity.Name;
                    command.Parameters.Add("@Addres", SqlDbType.VarChar, 200).Value = entity.Address;
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

        public int Update(EntitySupplier entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_edit_supplier",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@SupplierID", SqlDbType.Int).Value = entity.SupplierId;
                    command.Parameters.Add("@MunicipalityId", SqlDbType.Int).Value = entity.MunicipalityId;
                    command.Parameters.Add("@Name", SqlDbType.VarChar, 70).Value = entity.Name;
                    command.Parameters.Add("@Addres", SqlDbType.VarChar, 200).Value = entity.Address;
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

        public int Delete(EntitySupplier entity)
        {
            var rowsAffected = 0;
            try
            {
                using (var connection = new SqlConnection(DataConnection.ConnectionString))
                {
                    var command = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "sp_delete_supplier",
                        Connection = connection
                    };
                    connection.Open();
                    command.Parameters.Add("@SupplierID", SqlDbType.Int).Value = entity.SupplierId;
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
