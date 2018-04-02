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
using ProduceManager.Form.UserControls;
using DevExpress.XtraPrinting.Preview;
using ProduceManager.Form.Utils;
using System.IO;
using DevExpress.XtraReports.UI;


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

        }

        private void _btnReportView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var view = _mdiService.JumpTo<ReportView>();

            var control = view as UserControl;
            var documentViewer = control.FindChildren<DocumentViewer>();
            _documentViewerRibbonController.DocumentViewer = documentViewer;

            _rpcReportPreview.Visible = true;
        }

        void _tabMainContainer_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            var focusedTabPage = _tabMainContainer.SelectedTabPage;
            var hasDocumentViewer = focusedTabPage != null && focusedTabPage.FindChildren<DocumentViewer>() != null;

            _rpcReportPreview.Visible = hasDocumentViewer;
            _ribbonControl.SelectedPage = hasDocumentViewer ? _rpReportPreview : _produceRibbonPage;
        }

        MemoryStream _ms;
        private void _btnReportDesigner_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var view = _mdiService.JumpTo<ReportDesigner>();
            DisplayDataSet ds = new DisplayDataSet("数据源", GetFieldDisplayName);
            ds.Tables.Add(GetTestData("tableName"));
            ds.Tables.Add(GetTestData("tableName2"));

            if (_ms == null)
            {
                MemoryStream ms = new MemoryStream();
                XtraReport rep = new XtraReport();
                rep.DataSource = ds;
                rep.SaveLayout(ms);
            }
            ReportDesignerHelper.ShowDesigner(_ms, ds, ms => _ms = ms);
        }

        /// <summary>
        /// 获取字段显示名称
        /// </summary>
        /// <param name="fieldAccessors">字段访问器</param>
        /// <returns></returns>
        public string GetFieldDisplayName(string[] fieldAccessors)
        {
            string fieldName = fieldAccessors[fieldAccessors.Length - 1];
            if (fieldName == "FirstName") { return "姓"; }
            else if (fieldName == "LastName") { return "名"; }
            else { return fieldName; }
        }

        private static DataTable GetTestData(string tableName)
        {
            DataTable dtPerson = new DataTable(tableName);

            dtPerson.Columns.Add("PersonID");
            dtPerson.Columns.Add("LastName");
            dtPerson.Columns.Add("FirstName");

            dtPerson.Columns["PersonID"].AutoIncrement = true;
            dtPerson.Columns["PersonID"].AutoIncrementSeed = 1;
            dtPerson.Columns["PersonID"].AutoIncrementStep = 1;

            DataColumn[] dcKeys = new DataColumn[1];
            dcKeys[0] = dtPerson.Columns["PersonID"];
            dtPerson.PrimaryKey = dcKeys;

            dtPerson.Rows.Add(null, "Davolio", "Nancy");
            dtPerson.Rows.Add(null, "Fuller", "Andrew");
            dtPerson.Rows.Add(null, "Leverling", "Janet");
            dtPerson.Rows.Add(null, "Dodsworth", "Anne");
            dtPerson.Rows.Add(null, "Buchanan", "Steven");
            dtPerson.Rows.Add(null, "Suyama", "Michael");
            dtPerson.Rows.Add(null, "Callahan", "Laura");

            DataTable dtJob = new DataTable(tableName + "Job");


            return dtPerson;

        }

        private static DataSet GetTestData2()
        {
            //先来建立ds数据库
            DataSet ds = new DataSet("ds");
            //再来建立tbClass和tbBoard两个数据表
            DataTable tbClass = new DataTable("tbClass");
            DataTable tbBoard = new DataTable("tbBoard");
            //把两个数据表tbClass和tbBoard加入数据库
            ds.Tables.Add(tbClass);
            ds.Tables.Add(tbBoard);
            //建立tbClass两列
            DataColumn ClassID = new DataColumn("ClassID", typeof(System.String));
            DataColumn ClassName = new DataColumn("ClassName", typeof(System.String));
            //设定ClassID列不允许为空
            ClassID.AllowDBNull = false;
            //把列加入tbClass表
            tbClass.Columns.Add(ClassID);
            tbClass.Columns.Add(ClassName);
            //设定tdClass表的主键
            tbClass.PrimaryKey = new DataColumn[] { ClassID };
            //建立tbBoard的三列
            DataColumn BoardID = new DataColumn("BoardID", typeof(System.String));
            DataColumn BoardName = new DataColumn("BoardName", typeof(System.String));
            DataColumn BoardClassID = new DataColumn("BoardClassID", typeof(System.String));
            //设定BoardID列不允许为空
            BoardID.AllowDBNull = false;
            //把列加入tbBoard表
            tbBoard.Columns.Add(BoardID);
            tbBoard.Columns.Add(BoardName);
            tbBoard.Columns.Add(BoardClassID);
            //设定tbBoard表的主键
            tbBoard.PrimaryKey = new DataColumn[] { BoardID };
            // 为两个表各加入5条记录
            for (int i = 1; i <= 5; i++)
            {
                //实例化tbClass表的行
                DataRow tbClassRow = tbClass.NewRow();
                //为行中每一列赋值
                tbClassRow["ClassID"] = Guid.NewGuid();
                tbClassRow["ClassName"] = string.Format("分类{0}", i);
                //把行加入tbClass表
                tbClass.Rows.Add(tbClassRow);
                //实例化tbBoard表的行
                DataRow tbBoardRow = tbBoard.NewRow();
                //为行中每一列赋值
                tbBoardRow["BoardID"] = Guid.NewGuid();
                tbBoardRow["BoardName"] = string.Format("版块{0}", i);
                tbBoardRow["BoardclassID"] = tbClassRow["ClassID"];
                //把行加入tbBoard表
                tbBoard.Rows.Add(tbBoardRow);
            }

            //构建父子关系
            ds.Relations.Add("板块分类", ClassID, BoardClassID);
            return ds;
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