using DevExpress.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProduceManager.Form
{
    /// <summary>
    /// 中文名称显示数据集
    /// </summary>
    public class DisplayDataSet : DataSet, IDisplayNameProvider
    {
        string _dsName = "数据源";
        Func<string[], string> _fieldNameFunc = p =>
        {
            string fieldName = p[p.Length - 1];
            return fieldName;
        };

        /// <summary>
        /// 中文名称显示数据集
        /// </summary>
        /// <param name="dataSourceName">数据源名称</param>
        /// <param name="fieldNameFunc">字段名称回掉函数</param>
        public DisplayDataSet(string dataSourceName, Func<string[], string> fieldNameFunc = null)
        {
            if (!string.IsNullOrWhiteSpace(dataSourceName))
            {
                _dsName = dataSourceName;
            }
            if (fieldNameFunc != null)
            {
                _fieldNameFunc = fieldNameFunc;
            }
        }

        /// <summary>
        /// 获取数据源显示名称
        /// </summary>
        public string GetDataSourceDisplayName()
        {
            return _dsName;
        }

        /// <summary>
        /// 获取字段显示名称
        /// </summary>
        /// <param name="fieldAccessors">字段访问器</param>
        /// <returns></returns>
        public string GetFieldDisplayName(string[] fieldAccessors)
        {
            return _fieldNameFunc(fieldAccessors);
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // MyDataSet
            // 
            this.DataSetName = "数据源";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        }

    }
}
