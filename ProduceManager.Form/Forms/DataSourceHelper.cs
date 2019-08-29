using NLog;
using ProduceManager.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace ProduceManager.Forms
{

    public static class DataSourceHelper
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private static readonly Dictionary<string, object> _defaultParametersDictionary = new Dictionary<string, object>();

        public static DisplayDataSet GetDataSource(string sql, Dictionary<string, object> parametersDictionary = null)
        {
            parametersDictionary = parametersDictionary ?? _defaultParametersDictionary;
            DisplayDataSet ds = new DisplayDataSet("数据源", null);

            try
            {
                var connectionSetting = SystemConfig.ConnectionName.Length < 10
                    ? ConfigurationManager.ConnectionStrings[SystemConfig.ConnectionName]
                    : new ConnectionStringSettings("sqlitedb", SystemConfig.ConnectionName, "System.Data.SQLite.EF6");
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

                    foreach (var key in parametersDictionary.Keys)
                    {
                        var parameter = cmd.CreateParameter();
                        parameter.DbType = GetDbType(parametersDictionary[key]);
                        parameter.ParameterName = "@" + key;
                        parameter.Value = parametersDictionary[key];

                        cmd.Parameters.Add(parameter);
                    }

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

        private static DbType GetDbType(object v)
        {
            var type = Type.GetTypeCode(v.GetType());

            switch (type)
            {
                case TypeCode.Boolean:
                    break;
                case TypeCode.Byte:
                case TypeCode.Char:
                case TypeCode.SByte:
                case TypeCode.Int16:
                case TypeCode.UInt16:
                case TypeCode.Int32:
                case TypeCode.UInt32:
                    return DbType.Int32;
                case TypeCode.Int64:
                case TypeCode.UInt64:
                    return DbType.Int64;
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Decimal:
                    return DbType.Double;
                case TypeCode.DateTime:
                    return DbType.DateTime;
                case TypeCode.String:
                default:
                    return DbType.String;
            }
            return DbType.String;
        }
    }
}