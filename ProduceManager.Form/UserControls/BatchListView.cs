using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProduceManager.Forms.Persistence;
using ProduceManager.Forms.Utils;
using DevExpress.XtraEditors;

namespace ProduceManager.Forms
{
    public partial class BatchListView : UserControl, IView
    {
        private IList<BatchViewModel> _batchList;

        public IMdiService MdiService { get; set; }

        public string Caption { get { return "批次管理"; } }

        public BatchListView()
        {
            InitializeComponent();
            this.Load += BatchListView_Load;
        }

        void BatchListView_Load(object sender, EventArgs e)
        {
            //GridDragHelper.Register(_gridControl);
            XtraGridHelper.SetSortable(_gridView);//禁用排序
            XtraGridHelper.SetGridViewStyle(_gridView, new[] { _colOperation });
            XtraGridHelper.DrawRowIndicator(_gridView);   //初始化序号 
            XtraGridHelper.BindCopyToCtrlC(gridControl);
            Query();
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new AddBatchForm())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Query();
                }
            }
        }

        private void _btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void Query()
        {
            var currentBatchId = GetFocusedBatchId();
            gridControl.DataSource = _batchList = ApplicationService.Instanse.GetAllBatches();

            JumpTo(currentBatchId);
        }

        private void _riOperation_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                MdiService.JumpTo<ProduceDetailView>();
            }
            else if (e.Button.Index == 1)
            {
                var batch = GetFocusedBatch();
                if (batch == null)
                {
                    MessageBoxHelper.Warn("没有找到批次。");
                    return;
                }

                using (var dlg = new AddBatchForm(batch.Id))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                        Query();
                }
            }
            else if (e.Button.Index == 2)
            {
                var batch = GetFocusedBatch();
                if (batch == null)
                {
                    MessageBoxHelper.Warn("没有找到批次。");
                    return;
                }

                if (MessageBoxHelper.Question(string.Format("您确定要删除批次“{0}”吗?", batch.BatchNo)))
                {
                    ApplicationService.Instanse.DeleteBatch(batch.Id);
                }
            }
        }

        private void _gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            var batchViewModel = _batchList[e.ListSourceRowIndex];

            if (e.Column == _colState)
            {
                if (batchViewModel.IsDeleted)
                    e.DisplayText = "已删除";
                else if (batchViewModel.IsProductDeleted)
                    e.DisplayText = "产品已删除";
                else
                    e.DisplayText = "正常";
            }
        }

        private int GetFocusedBatchId()
        {
            var focusedBatch = GetFocusedBatch();
            var currentBatchId = focusedBatch != null ? focusedBatch.Id : -1;
            return currentBatchId;
        }

        private BatchViewModel GetFocusedBatch()
        {
            var rows = _gridView.GetSelectedRows();
            return rows.Any() ? (BatchViewModel)_gridView.GetRow(rows.First()) : null;
        }

        public void Jump(object parameter)
        {
            if (parameter is int batchId)
            {
                JumpTo(batchId);
            }
        }

        private void JumpTo(int batchId)
        {
            var batch = _batchList.FirstOrDefault(x => x.Id == batchId);
            var index = _batchList.IndexOf(batch);
            _gridView.FocusedRowHandle = _gridView.GetRowHandle(index);
        }

    }
}
