using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using ProduceManager.Forms.UserControls;
using ProduceManager.Forms.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace ProduceManager.Forms
{
    /// <summary>
    /// 报表设计器辅助类
    /// </summary>
    public class ReportDesignerHelper
    {
        public static void ShowDesigner(byte[] reportContent, string dataSourceSql, Action<byte[]> saveAction, string reportDisplayName = null, System.Windows.Forms.Form parentForm = null)
        {
            var wraper = new ReportWraper(dataSourceSql, reportContent);

            var report = wraper.CreateReport();
            report.DisplayName = string.IsNullOrWhiteSpace(reportDisplayName) ? "报表" : reportDisplayName;
           
         

            // report.DataMember = "Report";
            ReportDesignerForm frm = new ReportDesignerForm();
            frm.OpenReport(report, saveAction);
            frm.ShowDialog(parentForm);
        }


        public static void ShowPreview(MemoryStream reportStream, DataSet ds)
        {
            if (reportStream == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("报表模板未设置。");
                return;
            }

            XtraReport report = new XtraReport();
            report.DisplayName = "Report";

            try
            {
                report.LoadLayout(reportStream);
            }
            catch
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("报表模板不正确，请重新设置报表模板");
                return;
            }

            report.DataSource = ds;

            report.ShowPreviewDialog();

        }

        public static void Print(MemoryStream reportStream, DataSet ds, string printName)
        {
            if (reportStream == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("报表模板未设置。");
                return;
            }

            XtraReport report = new XtraReport();
            report.DisplayName = "Report";

            try
            {
                report.LoadLayout(reportStream);
            }
            catch
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("报表模板不正确，请重新设置报表模板");
                return;
            }

            report.DataSource = ds;
            try
            {
                report.Print(printName);
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message);
            }
        }
    }
}