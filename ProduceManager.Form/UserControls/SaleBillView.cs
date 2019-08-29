using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ProduceManager.Core.Domains;
using ProduceManager.Core.Persistence;
using ProduceManager.Forms.Utils;

namespace ProduceManager.Forms.UserControls
{
    public partial class SaleBillView : UserControl, IView
    {
        readonly ApplicationService _service;
        private IList<SaleBill> _saleBillList;

        public IMdiService MdiService { get; set; }

        public string Caption { get { return "销售单管理"; } }

        public SaleBillView()
        {
            InitializeComponent();

            _service = ApplicationService.Instanse;
            this.Load += BatchListView_Load;
        }

        void BatchListView_Load(object sender, EventArgs e)
        {
            XtraGridHelper.SetSortable(_gridView);//禁用排序
            XtraGridHelper.SetGridViewStyle(_gridView, new[] { _colOperation });
            XtraGridHelper.DrawRowIndicator(_gridView);   //初始化序号 
            XtraGridHelper.BindCopyToCtrlC(gridControl);
            Query();
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new AddSaleBillForm())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    Query();
            }
        }

        private void _btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void Query()
        {
            var currentBatchId = GetFocusedSaleBillId();

            var keyword = _txtKeyword.Text;

            var minDate = new DateTime(2000, 1, 1);
            var startTime = _deStart.DateTime < minDate ? minDate : _deStart.DateTime;
            var endTime = _deEnd.DateTime < minDate ? DateTime.MaxValue : _deEnd.DateTime.AddDays(1).AddSeconds(-1);

            gridControl.DataSource = _saleBillList = _service.GetAllSaleBills()
                .Where(x => (string.IsNullOrWhiteSpace(keyword) || x.CustomeName.Contains(keyword))
                    && (x.Date >= startTime && x.Date <= endTime))
                .ToList();

            JumpTo(currentBatchId);
        }

        private void _gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            var saleBill = _saleBillList[e.ListSourceRowIndex];

            if (e.Column == _colState)
            {
                if (saleBill.IsDeleted)
                    e.DisplayText = "已删除";
                else
                    e.DisplayText = "正常";
            }
        }

        private void _riOperation_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                var saleBill = GetFocusedSaleBill();
                if (saleBill == null)
                {
                    MessageBoxHelper.Warn("没有找到销售单。");
                    return;
                }

                using (var dlg = new AddSaleBillForm(saleBill.Id))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                        Query();
                }
            }
            else if (e.Button.Index == 1)
            {
                var saleBill = GetFocusedSaleBill();
                if (saleBill == null)
                {
                    MessageBoxHelper.Warn("没有找到销售单。");
                    return;
                }

                if (MessageBoxHelper.Question(string.Format("您确定要删除销售单“{0}”吗?", saleBill.GetDisplayText())))
                {
                    _service.DeleteSaleBill(saleBill.Id);
                    Query();
                }
            }
        }

        private int GetFocusedSaleBillId()
        {
            var focusedBatch = GetFocusedSaleBill();
            var currentBatchId = focusedBatch != null ? focusedBatch.Id : -1;
            return currentBatchId;
        }

        private SaleBill GetFocusedSaleBill()
        {
            var rows = _gridView.GetSelectedRows();
            return rows.Any() ? (SaleBill)_gridView.GetRow(rows.First()) : null;
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
            var batch = _saleBillList.FirstOrDefault(x => x.Id == batchId);
            var index = _saleBillList.IndexOf(batch);
            _gridView.FocusedRowHandle = _gridView.GetRowHandle(index);
        }
    }
}
