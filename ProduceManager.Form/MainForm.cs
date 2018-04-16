using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraTab;
using ProduceManager.Forms.UserControls;
using DevExpress.XtraPrinting.Preview;
using ProduceManager.Forms.Utils;
using System.IO;
using DevExpress.XtraReports.UI;


namespace ProduceManager.Forms
{
    public partial class MainForm : RibbonForm
    {
        IMdiService _mdiService;

        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
            InitGrid();
            _tabMainContainer.SelectedPageChanged += _tabMainContainer_SelectedPageChanged;

            _mdiService = new MdiService(this);
        }

        void InitSkinGallery()
        {
            //SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        void InitGrid()
        {
            //gridDataList.Add(new Person("John", "Smith"));
            //gridDataList.Add(new Person("Gabriel", "Smith"));
            //gridDataList.Add(new Person("Ashley", "Smith", "some comment"));
            //gridDataList.Add(new Person("Adrian", "Smith", "some comment"));
            //gridDataList.Add(new Person("Gabriella", "Smith", "some comment"));
            //gridControl.DataSource = gridDataList;
        }

        public class MdiService : IMdiService
        {
            private MainForm _form;

            public MdiService(MainForm mainForm)
            {
                _form = mainForm;
            }

            public IView JumpTo<T>(object parameter) where T : UserControl, IView, new()
            {
                IView view;
                _form._tabMainContainer.SelectedTabPage = LoadTabPage<T>(out view, parameter);
                return view;
            }

            private XtraTabPage LoadTabPage<T>(out IView view, object parameter = null) where T : UserControl, IView, new()
            {
                UserControl userControl = null;
                XtraTabPage tabPage = null;
                view = null;

                foreach (var control in _form._tabMainContainer.TabPages.Select(x => x.Controls.OfType<IView>().FirstOrDefault()))
                {
                    if (control is T)
                    {
                        view = control;
                        userControl = control as UserControl;
                        tabPage = userControl.Parent as XtraTabPage;
                    }
                }

                if (userControl == null)
                {
                    userControl = new T()
                    {
                        MdiService = this,
                    };
                    view = (IView)userControl;

                    tabPage = new XtraTabPage
                    {
                        Text = ((IView)userControl).Caption,
                    };

                    tabPage.Controls.Add(userControl);
                    userControl.Dock = DockStyle.Fill;

                    _form._tabMainContainer.TabPages.Add(tabPage);
                }

                view.Jump(parameter);
                return tabPage;
            }
        }

        private void _btnBatchManage_ItemClick(object sender, ItemClickEventArgs e)
        {
            _mdiService.JumpTo<BatchListView>();
        }

        private void _btnProduceDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            _mdiService.JumpTo<ProduceDetailView>();
        }

        private void _btnWorkerManage_ItemClick(object sender, ItemClickEventArgs e)
        {
            _mdiService.JumpTo<WorkerListView>();
        }

        private void _btnProcedureManage_ItemClick(object sender, ItemClickEventArgs e)
        {
            _mdiService.JumpTo<ProcedureListView>();
        }

        private void _btnProductManage_ItemClick(object sender, ItemClickEventArgs e)
        {
            _mdiService.JumpTo<ProductListView>();
        }

        private void _btnPriceManage_ItemClick(object sender, ItemClickEventArgs e)
        {
            _mdiService.JumpTo<PriceConfigView>();
        }

        private void _btnReportView_ItemClick(object sender, ItemClickEventArgs e)
        {
            JumpToReportView();
        }

        private void JumpToReportView()
        {
            var view = _mdiService.JumpTo<ReportView>();

            var control = view as UserControl;
            _documentViewerRibbonController.DocumentViewer = control.FindChildren<DocumentViewer>();

            _rpcReportPreview.Visible = true;
        }

        void _tabMainContainer_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            var focusedTabPage = _tabMainContainer.SelectedTabPage;
            var hasDocumentViewer = focusedTabPage != null && focusedTabPage.FindChildren<DocumentViewer>() != null;

            _rpcReportPreview.Visible = hasDocumentViewer;
            var currentRibbonPage = _ribbonControl.SelectedPage;
            _ribbonControl.SelectedPage = hasDocumentViewer ? _rpReportPreview : currentRibbonPage;
        }

        private void _btnReportDesigner_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void _btnAddReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var form = new AddReportForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    JumpToReportView();
            }
        }

        private void _btnSaleBill_ItemClick(object sender, ItemClickEventArgs e)
        {
            var view = _mdiService.JumpTo<SaleBillView>();
        }

        private void e_ItemClick(object sender, ItemClickEventArgs e)
        {
            new AddSaleBillForm().ShowDialog();
        }
    }



    public interface IMdiService
    {
        IView JumpTo<T>(object parameter = null) where T : UserControl, IView, new();

    }

    public interface IView
    {
        string Caption { get; }

        IMdiService MdiService { get; set; }

        void Jump(object parameter);
    }
}