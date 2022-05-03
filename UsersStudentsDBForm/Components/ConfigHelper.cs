using Microsoft.Extensions.Configuration;

namespace UsersStudentsDBForm.Components
{
    public static class ConfigHelper
    {
        public static string GetConnectionString()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddUserSecrets<Form1>()
                .Build();

            return config.GetConnectionString("DefaultDB");

        }
    }
}
