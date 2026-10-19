using Microsoft.Extensions.Configuration;

namespace BTCh11_Cau1
{
    internal static class AppConfig
    {
        public static string ConnectionString { get; private set; } = "";

        public static void Load()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            ConnectionString =
                config.GetConnectionString("DefaultConnection")
                ?? throw new Exception("Không đọc được ConnectionString");
        }
    }
}