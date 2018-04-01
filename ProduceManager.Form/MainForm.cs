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


namespace ProduceManager.Form
{
    public partial class MainForm : RibbonForm
    {
        IMdiService _mdiService;

        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
            InitGrid();

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

            public void JumpTo<T>(object parameter) where T : UserControl, IView, new()
            {
                _form._tabMainContainer.SelectedTabPage = LoadTabPage<T>(parameter);
            }

            private XtraTabPage LoadTabPage<T>(object parameter = null) where T : UserControl, IView, new()
            {
                UserControl userControl = null;
                IView userControlAsView = null;
                XtraTabPage tabPage = null;

                foreach (var control in _form._tabMainContainer.TabPages.Select(x => x.Controls.OfType<IView>().FirstOrDefault()))
                {
                    if (control is T)
                    {
                        userControlAsView = control;
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
                    userControlAsView = (IView)userControl;

                    tabPage = new XtraTabPage
                    {
                        Text = ((IView)userControl).Caption,
                    };

                    tabPage.Controls.Add(userControl);
                    userControl.Dock = DockStyle.Fill;

                    _form._tabMainContainer.TabPages.Add(tabPage);
                }

                userControlAsView.Jump(parameter);
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

        }

    }



    public interface IMdiService
    {
        void JumpTo<T>(object parameter = null) where T : UserControl, IView, new();

    }

    public interface IView
    {
        string Caption { get; }

        IMdiService MdiService { get; set; }

        void Jump(object parameter);
    }
}