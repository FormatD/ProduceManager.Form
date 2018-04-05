using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using ProduceManager.Form.Utils;
using ProduceManager.Form.Domains;
using ProduceManager.Form.Persistence;

namespace ProduceManager.Form
{

    public static class DataSourceHelper
    {
        public static DisplayDataSet GetDataSource(string sql)
        {
            DisplayDataSet ds = new DisplayDataSet("数据源", null);

            using (var conn = new SqlConnection("Server=.;Database=ProduceManage;Trusted_Connection=True;"))
            {
                var adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds);
            }
            return ds;
        }
    }
}