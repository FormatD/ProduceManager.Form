using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProduceManager.Form.Utils;
using ProduceManager.Form.Domains;
using ProduceManager.Form.Persistence;

namespace ProduceManager.Form
{
    public partial class ProduceDetailView : UserControl, IView
    {
        private IList<ProduceRecordViewModel> produceRecordList;
        private ApplicationService _service = ApplicationService.Instanse;

        public IMdiService MdiService { get; set; }

        public string Caption { get { return "生产详情"; } }

        public ProduceDetailView()
        {
            InitializeComponent();
            Load += ProduceDetailView_Load;
        }

        void ProduceDetailView_Load(object sender, EventArgs e)
        {
            XtraGridHelper.SetSortable(_gridView);//禁用排序
            XtraGridHelper.SetGridViewStyle(_gridView, new[] { _colOperation });
            XtraGridHelper.DrawRowIndicator(_gridView);   //初始化序号 
            XtraGridHelper.BindCopyToCtrlC(gridControl);
            Query();
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new AddProduceRecordForm())
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
            var currentProduceRecordId = GetFocusedProduceRecordId();
            gridControl.DataSource = produceRecordList = _service.GetAllProduceRecords();

            JumpTo(currentProduceRecordId);
        }

        private void _riOperation_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                var batch = GetFocusedProduceRecord();
                if (batch == null)
                {
                    MessageBoxHelper.Warn("没有找到生产记录。");
                    return;
                }

                using (var dlg = new AddProduceRecordForm(batch.Id))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                        Query();
                }
            }
            else if (e.Button.Index == 1)
            {
                var batch = GetFocusedProduceRecord();
                if (batch == null)
                {
                    MessageBoxHelper.Warn("没有找到生产记录。");
                    return;
                }

                if (MessageBoxHelper.Question(string.Format("您确定要删除生产记录“{0}”吗?", batch.Id)))
                {
                    _service.DeleteBatch(batch.Id);
                }
            }
        }

        private void _gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            var batchViewModel = produceRecordList[e.ListSourceRowIndex];

            if (e.Column == _colState)
            {
                if (batchViewModel.IsDeleted)
                    e.DisplayText = "已删除";
                //else if (batchViewModel)
                //    e.DisplayText = "产品已删除";
                else
                    e.DisplayText = "正常";
            }
        }

        private int GetFocusedProduceRecordId()
        {
            var focusedBatch = GetFocusedProduceRecord();
            var currentBatchId = focusedBatch != null ? focusedBatch.Id : -1;
            return currentBatchId;
        }

        private ProduceRecordViewModel GetFocusedProduceRecord()
        {
            var rows = _gridView.GetSelectedRows();
            return rows.Any() ? (ProduceRecordViewModel)_gridView.GetRow(rows.First()) : null;
        }

        public void Jump(object parameter)
        {
            if (parameter is int)
            {
                var batchId = (int)parameter;
                JumpTo(batchId);
            }
        }

        private void JumpTo(int batchId)
        {
            var batch = produceRecordList.FirstOrDefault(x => x.Id == batchId);
            var index = produceRecordList.IndexOf(batch);
            _gridView.FocusedRowHandle = _gridView.GetRowHandle(index);
        }
    }
}
