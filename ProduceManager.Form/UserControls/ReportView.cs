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

namespace ProduceManager.Forms.UserControls
{
    public partial class ReportView : XtraUserControl, IView
    {
        readonly ApplicationService _service = ApplicationService.Instanse;
        private ReportItem _reportItem;

        public ReportView()
        {
            InitializeComponent();

            Load += ReportView_Load;
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            _tlReports.FocusedNodeChanged += _tlReports_FocusedNodeChanged;
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
            var reportItem = _tlReports.FocusedNode.Tag as Domains.ReportItem;
            if (reportItem == null)
                return;

            using (var dlg = new AddReportForm(reportItem.Id))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Reload();
                }
            }
        }

        private void Reload()
        {
            _tlReports.Nodes.Clear();

            var root = _tlReports.AppendNode(new object[] { "所有报表" }, null, null);
            foreach (var report in _service.GetAllReports())
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

            var report = new XtraReport { };

            report.ParametersRequestBeforeShow += Report_ParametersRequestBeforeShow;
            report.ParametersRequestSubmit += Report_ParametersRequestSubmit;
            report.LoadLayout(new MemoryStream(_reportItem.Content));
            report.CreateDocument();
            documentViewer1.DocumentSource = report;

            documentViewer1.Refresh();
        }

        private void Report_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            var report = sender as XtraReport;

            if (report == null)
                return;

            if (_reportItem == null)
                return;

            var parameterDictionary = e.ParametersInformation.ToDictionary(x => x.Parameter.Name, x => x.Parameter.Value);

            report.DataSource = DataSourceHelper.GetDataSource(_reportItem.DataSource, parameterDictionary);
        }

        private void Report_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            var report = sender as XtraReport;

            if (report == null)
                return;

            var parameterDictionary = e.ParametersInformation.ToDictionary(x => x.Parameter.Name, x => x.Parameter.Value);

            report.DataSource = DataSourceHelper.GetDataSource(_reportItem.DataSource, parameterDictionary);
        }
    }
}
