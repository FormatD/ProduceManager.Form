using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.Utils;

namespace ProduceManager.Form
{
    public partial class ReportDesignerForm : XtraForm
    {

        #region [Form]

        public ReportDesignerForm()
        {
            InitializeComponent();
            this.ShowIcon = true;
            //this.Icon = Resources.ReportDesignerIcon;
            this.reportDesigner1.DesignPanelLoaded += mdiController_DesignPanelLoaded;
        }

        private void ReportDesignerForm_Load(object sender, EventArgs e)
        {

        }

        private void ReportDesignerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cancelCloseForm)
            {
                _cancelCloseForm = false;
                e.Cancel = true;
            }
            else
            {
                _saveAction = null;
                _srcReport = null;
            }
        }

        #endregion

        #region [OpenReport]

        public static Action<MemoryStream> _saveAction = null;
        private static XtraReport _srcReport = null;
        public static bool _cancelCloseForm = false;

        /// <summary>
        /// 打开报表
        /// </summary>
        /// <param name="srcReport">源报表</param>
        /// <param name="saveAction">保存方法</param>
        public void OpenReport(XtraReport srcReport, Action<MemoryStream> saveAction)
        {
            _saveAction = saveAction;
            _srcReport = srcReport;
            reportDesigner1.OpenReport(srcReport);
            InitCommandButton();
        }

        /// <summary>
        /// 初始化命令按钮
        /// </summary>
        private void InitCommandButton()
        {
            ActiveXRDesignPanel.SetCommandVisibility(ReportCommand.NewReportWizard, CommandVisibility.None);
            ActiveXRDesignPanel.SetCommandVisibility(ReportCommand.VerbReportWizard, CommandVisibility.None);
            ActiveXRDesignPanel.SetCommandVisibility(ReportCommand.NewReport, CommandVisibility.None);
            ActiveXRDesignPanel.SetCommandVisibility(ReportCommand.SaveAll, CommandVisibility.None);
            ActiveXRDesignPanel.SetCommandVisibility(ReportCommand.SaveFileAs, CommandVisibility.None);
            ActiveXRDesignPanel.SetCommandVisibility(ReportCommand.OpenFile, CommandVisibility.None);
        }

        /// <summary>
        /// 当前激活报表设计容器
        /// </summary>
        public XRDesignPanel ActiveXRDesignPanel
        {
            get { return reportDesigner1.ActiveDesignPanel; }
        }

        #endregion

        #region [SaveReport]

        void mdiController_DesignPanelLoaded(object sender, DesignerLoadedEventArgs e)
        {
            XRDesignPanel panel = (XRDesignPanel)sender;
            reportDesigner1.AddCommandHandler(new SaveCommandHandler(panel));
            reportDesigner1.XtraTabbedMdiManager.DocumentActivate += XtraTabbedMdiManager_DocumentActivate;
        }

        void XtraTabbedMdiManager_DocumentActivate(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
            e.Document.Properties.AllowClose = DefaultBoolean.False;
            e.Document.Properties.AllowFloat = DefaultBoolean.False;
        }

        public class SaveCommandHandler : ICommandHandler
        {
            XRDesignPanel panel;

            public SaveCommandHandler(XRDesignPanel panel)
            {
                this.panel = panel;
            }

            public void HandleCommand(ReportCommand command, object[] args)
            {
                bool saveReport = true;
                bool exitDesigner = false;
                if (command == ReportCommand.Closing && panel.ReportState == ReportState.Changed)
                {
                    //询问是否保存修改
                    var dr = XtraMessageBox.Show("报表已修改是否保存？", "确认", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    saveReport = dr == DialogResult.Yes;
                    exitDesigner = dr != DialogResult.Cancel;
                    if (!exitDesigner)
                    {
                        _cancelCloseForm = true;
                    }
                    else if (saveReport)
                    {
                        Save();
                    }
                    else
                    {
                        _cancelCloseForm = false;
                    }
                }
                else if (command != ReportCommand.Closing)
                {
                    Save();
                }

            }

            public bool CanHandleCommand(DevExpress.XtraReports.UserDesigner.ReportCommand command, ref bool useNextHandler)
            {
                useNextHandler =
                    !(command == ReportCommand.SaveFile ||
                    command == ReportCommand.SaveFileAs ||
                    command == ReportCommand.Closing);
                return !useNextHandler;
            }

            /// <summary>
            /// 保存
            /// </summary>
            private void Save()
            {
                //自定义报表存储
                StoreReport(panel.Report);
                //阻止“报表已修改”对话框弹出
                panel.ReportState = ReportState.Saved;
            }


            private void StoreReport(XtraReport report)
            {
                MemoryStream stream = new MemoryStream();
                report.SaveLayout(stream);
                if (panel.ReportState == ReportState.Changed)
                {
                    _saveAction(stream);
                }
            }

        }

        #endregion
    }
}