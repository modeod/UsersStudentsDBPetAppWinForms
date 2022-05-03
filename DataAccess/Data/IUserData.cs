using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IUserData
    {
        Task<IEnumerable<CountModel>> CountBy(string _columName);
        Task DeleteUser(string id);
        Task<IEnumerable<UserModel>> GetAllUsers();
        Task<IEnumerable<ColumnModel>> GetColumn(string _columName);
        Task<IEnumerable<UserModel>> GetUsersBy(UserModel parameters);
        Task InsertUser(UserModel user);
        Task UpdateUser(UserModel user);
    }
}