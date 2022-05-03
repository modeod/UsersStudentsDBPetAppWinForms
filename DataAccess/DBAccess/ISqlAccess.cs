
namespace DataAccess.DBAccess
{
    public interface ISqlAccess
    {
        Task<IEnumerable<T>> LoadDataQuery<T, U>(string query, U parameters, string connectionString = "Default");
        Task<IEnumerable<T>> LoadDataStored<T, U>(string storedProcedure, U parameters, string connectionString = "Default");
        Task SaveData<T>(string storedProcedure, T parameters, string connectionString = "Default");
    }
}