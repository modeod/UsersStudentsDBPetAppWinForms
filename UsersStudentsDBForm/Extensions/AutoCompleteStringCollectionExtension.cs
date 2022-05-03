using DataAccess.Data;
using DataAccess.Models;

namespace UsersStudentsDBForm.Extensions
{
    public static class AutoCompleteStringCollectionExtension
    {
        public static async Task UpdateColumn(this AutoCompleteStringCollection autoCompleteStringCollection, UserData dataMethods, string columnName)
        {
            autoCompleteStringCollection.Clear();
            var rows = await dataMethods.GetColumn(columnName);

            List<string> rowsList = rows
                .Select<ColumnModel, string>(x => x.ColumnValue).Where(x => x != null).ToList();
            rowsList.Add("null");

            string[] res = rowsList.ToArray();
            autoCompleteStringCollection.AddRange(res);
        }
    }
}
