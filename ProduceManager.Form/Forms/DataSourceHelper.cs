using NLog;
using System;
using System.Configuration;
using System.Data.Common;

namespace ProduceManager.Forms
{

    public static class DataSourceHelper
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public static DisplayDataSet GetDataSource(string sql)
        {
            DisplayDataSet ds = new DisplayDataSet("数据源", null);

            try
            {
                var connectionSetting = ConfigurationManager.ConnectionStrings[SystemConfig.ConnectionName];
                var provider = connectionSetting.ProviderName;
                var connectionString = connectionSetting.ConnectionString;

                var factory = DbProviderFactories.GetFactory(connectionSetting.ProviderName);

                using (var conn = factory.CreateConnection())
                {
                    conn.ConnectionString = (connectionSetting.ConnectionString);
                    var adapter = factory.CreateDataAdapter();
                    var cmd = factory.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    adapter.SelectCommand = cmd;

                    adapter.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                _logger.Warn(ex.Message);
                _logger.Warn(sql);
            }
            return ds;
        }
    }
}