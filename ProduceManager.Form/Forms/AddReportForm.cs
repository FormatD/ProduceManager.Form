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
    public partial class AddReportForm : XtraForm
    {
        private readonly ApplicationService _service = ApplicationService.Instanse;
        private int _id;
        private MemoryStream _memoryStream;
        private bool _isAddingNew = true;
        private ReportItem _report;

        public AddReportForm(int id)
            : this()
        {
            _id = id;
            _isAddingNew = false;
        }

        public AddReportForm()
        {
            InitializeComponent();
        }

        private void _btnDesign_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = DataSourceHelper.GetDataSource(_txtDataSource.Text);
                if (_memoryStream == null)
                {
                    _memoryStream = new MemoryStream();
                    var rep = new XtraReport();
                    rep.DataSource = ds;
                    rep.SaveLayout(_memoryStream);
                }

                ReportDesignerHelper.ShowDesigner(
                    _memoryStream,
                    ds,
                    ms => _memoryStream = ms);
            }
            catch (Exception ex)
            {
                MessageBoxHelper.Warn(ex.Message);
            }
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            var reportName = _txtReportName.Text;
            var dataSource = _txtDataSource.Text;
            if (string.IsNullOrWhiteSpace(reportName))
            {
                MessageBoxHelper.Warn("请输入报表名称。");
                return;
            }

            if (string.IsNullOrWhiteSpace(dataSource))
            {
                MessageBoxHelper.Warn("请输入数据源。");
                return;
            }

            if (_memoryStream == null || _memoryStream.Length == 0)
            {
                MessageBoxHelper.Warn("请先设计报表。");
                return;
            }

            _report.Content = _memoryStream.ToArray();
            _report.DataSource = dataSource;
            _report.Name = reportName;

            if (_isAddingNew)
                _service.AddReport(_report);
            else
                _service.SaveChanges();
        }

        private void AddReportForm_Load(object sender, EventArgs e)
        {
            _report = _isAddingNew ? new ReportItem() : _service.GetReport(_id);

            _txtReportName.Text = _report.Name;
            _txtDataSource.Text = _report.DataSource;
            _chkIsSystem.Checked = _report.IsSystem;

            _memoryStream = _report.Content == null ? null : new MemoryStream(_report.Content);

            if (!_isAddingNew)
            {
                Text = "修改报表";
                _btnAdd.Text = "保存(&S)";
            }
        }
    }
}