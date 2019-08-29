
namespace ProduceManager.Core
{
    public class SystemConfig
    {
        private const string _connectionString = @"Data Source=db\produce.db;Version=3;Password=laodengjiadeshuju";

        public static string ConnectionName { get; set; } = _connectionString; //"sqliteDb";// "Mssql";
    }
}
