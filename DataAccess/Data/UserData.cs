using DataAccess.DBAccess;
using DataAccess.Models;
using System.Data.SqlClient;
using System.Reflection;

namespace DataAccess.Data;

public class UserData : IUserData
{
    private readonly ISqlAccess _database;

    public UserData(string connectionString)
    {
        _database = new SqlAccess(connectionString);
    }

    public Task<IEnumerable<ColumnModel>> GetColumn(string _columName) =>
        _database.LoadDataStored<ColumnModel, dynamic>("dbo.spUserStudent_Column", new { columName = _columName });

    public Task<IEnumerable<UserModel>> GetUsersBy(UserModel parameters)
    {
        string query = "";
        bool notFirst = false;

        foreach (PropertyInfo prop in parameters.GetType().GetProperties())
        {
            if (prop.GetValue(parameters) != null && prop.GetValue(parameters).ToString().Trim() != "")
            {
                if (notFirst) { query += " AND ";  }
                if (!notFirst) { query += " WHERE "; notFirst = true; }
                query +=  prop.Name + " = N\'" + prop.GetValue(parameters).ToString() + "\'";
            }
        }

       return _database.LoadDataQuery<UserModel, dynamic>(
            @"SELECT * FROM dbo.UserStudent" + query, new { });
    }

    public async Task<IEnumerable<UserModel>> GetAllUsers()
    {
        var res = await _database.LoadDataStored<UserModel, dynamic>("dbo.spUserStudent_GetAll", new { });
        return res;
    }

    public Task<IEnumerable<CountModel>> CountBy(string _columName) =>
        _database.LoadDataStored<CountModel, dynamic>("dbo.spUserStudent_CountGroupByColum", _columName);

    public Task InsertUser(UserModel user) =>
        _database.SaveData("dbo.spUserStudent_Insert", user);

    public Task UpdateUser(UserModel user) =>
        _database.SaveData("dbo.spUserStudent_Update", user);

    public Task DeleteUser(string id) =>
        _database.SaveData("dbo.spUserStudent_Delete", new { Id = id });


}
