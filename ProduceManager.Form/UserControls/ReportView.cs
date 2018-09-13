using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ProduceManager.Forms.Persistence;
using System.IO;
using ProduceManager.Forms.Utils;
using DevExpress.XtraReports.UI;
using ProduceManager.Forms.Domains;
using ProduceManager.Forms.Messages;
using DevExpress.XtraReports.Parameters;

namespace ProduceManager.Forms.UserControls
{
    public partial class ReportView : XtraUserControl, IView
    {
        readonly ApplicationService _service = ApplicationService.Instanse;
        private ReportItem _reportItem;
        private IEnumerable<ReportItem> _allReports;

        public ReportView()
        {
            InitializeComponent();

            Load += ReportView_Load;
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            _tlReports.FocusedNodeChanged += _tlReports_FocusedNodeChanged;
            EventBus.Instanse.Subscrible((ExportReportMessage message) =>
            {
                using (var dlg = new SaveFileDialog())
                {
                    dlg.Title = "导出报表";
                    dlg.Filter = "报表文件|*.rpts";
                    dlg.DefaultExt = ".rpts";
                    dlg.AddExtension = true;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(dlg.FileName, _allReports.ToJson());
                    }
                }
            });
            EventBus.Instanse.Subscrible((ImportReportMessage message) =>
            {
                using (var dlg = new OpenFileDialog())
                {
                    dlg.Title = "导入报表";
                    dlg.Filter = "报表文件|*.rpts";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            var importReports = File.ReadAllText(dlg.FileName).FromJson<List<ReportItem>>();

                            _service.DeleteAllReport();
                            foreach (var report in importReports)
                            {
                                _service.AddReport(report);
                            }

                            Reload();
                        }
                        catch (Exception ex)
                        {
                            MessageBoxHelper.Warn("导入失败。" + ex.Message);
                        }
                    }
                }
            });
            Reload();
        }

        public string Caption
        {
            get { return "报表"; }
        }

        public IMdiService MdiService { get; set; }

        public void Jump(object parameter)
        {
            Reload();
        }

        private void _riOperate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!(_tlReports.FocusedNode.Tag is ReportItem reportItem))
                return;

            if (e.Button.Index == 0)
            {
                using (var dlg = new AddReportForm(reportItem.Id))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        Reload();
                    }
                }
            }
            else if (e.Button.Index == 1)
            {
                if (MessageBoxHelper.Question($"确定要删除报表“{reportItem.Name}”吗？"))
                {
                    _service.DeleteReport(reportItem);
                    Reload();
                }
            }
        }

        private void Reload()
        {
            _tlReports.Nodes.Clear();

            var root = _tlReports.AppendNode(new object[] { "所有报表" }, null, null);
            foreach (var report in (_allReports = _service.GetAllReports()))
            {
                _tlReports.AppendNode(new object[] { report.Name }, root, report);
            }

            _tlReports.ExpandAll();
        }

        private void _tlReports_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (_tlReports.FocusedNode == null)
                return;

            _reportItem = _tlReports.FocusedNode.Tag as ReportItem;
            if (_reportItem == null)
                return;
            if (_reportItem.Content == null || _reportItem.Content.Length == 0)
            {
                MessageBoxHelper.Warn("未设计的报表。");
                return;
            }

            using (WaitHelper.ShowWaitForm("报表加载中", AppHelper.MainForm))
            {
                var wraper = new ReportWraper(_reportItem.DataSource, _reportItem.Content);
                documentViewer1.DocumentSource = wraper.CreateReport();

                documentViewer1.Refresh();
            }
        }
    }

    public class ReportWraper
    {
        private readonly string _dataSource;
        private readonly byte[] _content;

        public ReportWraper(string dataSource, byte[] content)
        {
            _dataSource = dataSource;
            _content = content;
        }

        public XtraReport CreateReport()
        {
            var report = new XtraReport { };

            report.ParametersRequestBeforeShow += Report_ParametersRequestBeforeShow;
            report.ParametersRequestSubmit += Report_ParametersRequestSubmit;
            report.LoadLayout(new MemoryStream(_content));
            report.CreateDocument();

            report.DataSource = DataSourceHelper.GetDataSource(_dataSource, RetrieveDefaultParameterDictionary(report));

            return report;
        }

        private static Dictionary<string, object> RetrieveDefaultParameterDictionary(XtraReport report)
        {
            var parameterDictionary = report.Parameters.OfType<Parameter>().ToDictionary(x => x.Name, x => x.Value);

            foreach (var key in parameterDictionary.Keys.ToList())
            {
                if (key.EqualsIgnoreCase("Year"))
                {
                    parameterDictionary[key] = DateTime.Now.Year;
                }
                else if (key.EqualsIgnoreCase("Month"))
                {
                    parameterDictionary[key] = DateTime.Now.Month;
                }
            }

            return parameterDictionary;
        }

        private void Report_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {

            if (!(sender is XtraReport report))
                return;

            var parameterDictionary = e.ParametersInformation.ToDictionary(x => x.Parameter.Name, x => x.Parameter.Value);

            report.DataSource = DataSourceHelper.GetDataSource(_dataSource, parameterDictionary);
        }

        private void Report_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {

            if (!(sender is XtraReport report))
                return;

            var parameterDictionary = e.ParametersInformation.ToDictionary(x => x.Parameter.Name, x => x.Parameter.Value);
            report.DataSource = DataSourceHelper.GetDataSource(_dataSource, parameterDictionary);
        }

    }
}
