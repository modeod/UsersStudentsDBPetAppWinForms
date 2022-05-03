using System.ComponentModel;

namespace UsersStudentsDBForm.Extensions
{
    public static class DataViewExtension
    {
        public static async Task UpdateDataViewAsync<T>(this DataGridView dataGridView, Func<Task<IEnumerable<T>>> dataMethod)
        {
            var res = (await dataMethod()).ToList();
            dataGridView.DataSource = new BindingList<T>((await dataMethod()).ToList());
        }
        public static async Task UpdateDataViewAsync<T>(this DataGridView dataGridView, Func<DataAccess.Models.UserModel, Task<IEnumerable<T>>> dataMethod, DataAccess.Models.UserModel newUser)
        {
            var res = (await dataMethod(newUser)).ToList();
            dataGridView.DataSource = new BindingList<T>(res);
        }

    }
}
