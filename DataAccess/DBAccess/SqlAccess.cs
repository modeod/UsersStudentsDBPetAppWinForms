using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using DataAccess.Models;
using System.Net;
using System.Security;

namespace DataAccess.DBAccess;

public class SqlAccess : ISqlAccess
{
    private string _connectionString;

    public SqlAccess(string connectionString)
    {
        _connectionString = connectionString;
    }

    public static bool CheckConnection(string connectionString, string password)
    {
        try
        {
            string connStr = connectionString + ";Password=" + password;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connStr);

            using (IDbConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                connection.Close();
                return true;
            }
        }
        catch (SqlException ex)
        {
            return false;
        }

    }

    public async Task<IEnumerable<T>> LoadDataStored<T, U>(
        string storedProcedure,
        U parameters,
        string connectionString = "Default")
    {
        using (IDbConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var res = await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            return res;
        }
    }

    public async Task<IEnumerable<T>> LoadDataQuery<T, U>(
        string query,
        U parameters,
        string connectionString = "Default")
    {
        using (IDbConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            return await connection.QueryAsync<T>(query, parameters);
        }
    }

    public async Task SaveData<T>(
        string storedProcedure,
        T parameters,
        string connectionString = "Default")
    {
        using (IDbConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
