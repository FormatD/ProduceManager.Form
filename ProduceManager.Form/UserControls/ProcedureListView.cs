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
using ProduceManager.Forms.Domains;
using ProduceManager.Forms.Utils;

namespace ProduceManager.Forms
{
    public partial class ProcedureListView : UserControl, IView
    {
        ApplicationService _service;
        private IList<Procedure> _procedureList;

        public IMdiService MdiService { get; set; }

        public string Caption { get { return "工序管理"; } }

        public ProcedureListView()
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
            using (var dlg = new AddProcedureForm())
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
            var currentBatchId = GetFocusedProcedureId();
            gridControl.DataSource = _procedureList = _service.GetAllProcedures();

            JumpTo(currentBatchId);
        }

        private void _gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            var procedure = _procedureList[e.ListSourceRowIndex];

            if (e.Column == _colState)
            {
                if (procedure.IsDeleted)
                    e.DisplayText = "已删除";
                else
                    e.DisplayText = "正常";
            }
        }

        private void _riOperation_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                MdiService.JumpTo<ProduceDetailView>();
            }
            else if (e.Button.Index == 1)
            {
                var procedure = GetFocusedProcedure();
                if (procedure == null)
                {
                    MessageBoxHelper.Warn("没有找到工序。");
                    return;
                }

                using (var dlg = new AddProcedureForm(procedure.Id))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                        Query();
                }
            }
            else if (e.Button.Index == 2)
            {
                var procedure = GetFocusedProcedure();
                if (procedure == null)
                {
                    MessageBoxHelper.Warn("没有找到工序。");
                    return;
                }

                if (MessageBoxHelper.Question(string.Format("您确定要删除工序“{0}”吗?", procedure.GetDisplayText())))
                {
                    _service.DeleteProcedure(procedure.Id);
                }
            }
        }

        private int GetFocusedProcedureId()
        {
            var focusedBatch = GetFocusedProcedure();
            var currentBatchId = focusedBatch != null ? focusedBatch.Id : -1;
            return currentBatchId;
        }

        private Procedure GetFocusedProcedure()
        {
            var rows = _gridView.GetSelectedRows();
            return rows.Any() ? (Procedure)_gridView.GetRow(rows.First()) : null;
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
            var batch = _procedureList.FirstOrDefault(x => x.Id == batchId);
            var index = _procedureList.IndexOf(batch);
            _gridView.FocusedRowHandle = _gridView.GetRowHandle(index);
        }

    }
}
