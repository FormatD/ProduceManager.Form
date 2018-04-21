using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProduceManager.Forms
{
    public class SystemConfig
    {
        private const string _connectionString = @"Data Source=db\produce.db;Version=3;Password=laodengjiadeshuju";
        public static string ConnectionName { get; set; } = _connectionString; //"sqliteDb";// "Mssql";


    }
}
