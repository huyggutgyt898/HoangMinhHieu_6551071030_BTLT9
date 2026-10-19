using Microsoft.Extensions.Configuration;
using Serilog;

namespace BTCh11_Cau1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json",
                    optional: false,
                    reloadOnChange: true)
                .Build();

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.File(
                    "Logs/log-.txt",
                    rollingInterval: RollingInterval.Day)
                .CreateLogger();

            try
            {
                ApplicationConfiguration.Initialize();
                AppConfig.Load();

                Log.Information("Ứng dụng khởi động");

                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi chương trình");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}