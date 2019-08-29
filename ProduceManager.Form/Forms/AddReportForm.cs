using System;
using System.Linq;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraReports.UI;
using ProduceManager.Forms.Utils;
using ProduceManager.Core.Domains;
using ProduceManager.Core.Persistence;

namespace ProduceManager.Forms
{
    public partial class AddReportForm : XtraForm
    {
        private readonly ApplicationService _service = ApplicationService.Instanse;
        private readonly int _id;
        private byte[] _reportContent;
        private readonly bool _isAddingNew = true;
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

            _txtDataSource.Language = FastColoredTextBoxNS.Language.SQL;
            _txtDataSource.WordWrap = true;

        }

        private void _btnDesign_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = DataSourceHelper.GetDataSource(_txtDataSource.Text);
                if (_reportContent == null)
                {
                    var memoryStream = new MemoryStream();
                    var rep = new XtraReport
                    {
                        DataSource = ds
                    };
                    rep.SaveLayout(memoryStream);
                    _reportContent = memoryStream.ToArray();
                }

                ReportDesignerHelper.ShowDesigner(
                    _reportContent,
                    _txtDataSource.Text,
                    ms => _reportContent = ms);
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

            if (_reportContent == null || _reportContent.Length == 0)
            {
                MessageBoxHelper.Warn("请先设计报表。");
                return;
            }

            _report.Content = _reportContent.ToArray();
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

            _reportContent = _report.Content;

            if (!_isAddingNew)
            {
                Text = "修改报表";
                _btnAdd.Text = "保存(&S)";
            }
        }
    }
}