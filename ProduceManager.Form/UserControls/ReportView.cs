using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ProduceManager.Form.Persistence;
using System.IO;
using ProduceManager.Form.Utils;

namespace ProduceManager.Form.UserControls
{
    public partial class ReportView : XtraUserControl, IView
    {
        ApplicationService _service = ApplicationService.Instanse;

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

            var reportItem = _tlReports.FocusedNode.Tag as Domains.ReportItem;
            if (reportItem == null)
                return;
            if (reportItem.Content == null || reportItem.Content.Length == 0)
            {
                MessageBoxHelper.Warn("未设计的报表。");
                return;
            }

            var report = new DevExpress.XtraReports.UI.XtraReport
            {
                DataSource = DataSourceHelper.GetDataSource(reportItem.DataSource)
            };
            report.LoadLayout(new MemoryStream(reportItem.Content));
            report.CreateDocument();
            documentViewer1.DocumentSource = report;
        }
    }
}
