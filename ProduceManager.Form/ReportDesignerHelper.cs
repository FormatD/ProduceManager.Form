using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace ProduceManager.Form
{
    /// <summary>
    /// 报表设计器辅助类
    /// </summary>
    public class ReportDesignerHelper
    {
        /// <summary>
        /// 显示设计器
        /// </summary>
        /// <param name="reportStream">报表文件内存流</param>
        /// <param name="ds">DataSet数据集，包含结构定义，和测试数据，结构定义用于报表设计，测试数据用于报表预览。</param>
        /// <param name="saveAction">保存行为</param>
        /// <param name="reportDisplayName">报表显示名称</param>
        /// <param name="parentForm">父窗体</param>
        public static void ShowDesigner(Stream reportStream, DataSet ds, Action<MemoryStream> saveAction, string reportDisplayName = null, System.Windows.Forms.Form parentForm = null)
        {
            XtraReport report = new XtraReport();
            report.DisplayName = string.IsNullOrWhiteSpace(reportDisplayName) ? "报表" : reportDisplayName;
            if (reportStream != null)
            {
                try
                {
                    report.LoadLayout(reportStream);
                }
                catch
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("报表模板不正确，请重新设置报表模板");
                    return;
                }
            }
            report.DataSource = ds;
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