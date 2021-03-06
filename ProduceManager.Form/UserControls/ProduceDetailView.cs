﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ProduceManager.Core.Domains;
using ProduceManager.Core.Persistence;
using ProduceManager.Forms.Utils;

namespace ProduceManager.Forms
{
    public partial class ProduceDetailView : UserControl, IView
    {
        private IList<ProduceRecordViewModel> produceRecordList;
        private readonly ApplicationService _service = ApplicationService.Instanse;

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
            _cbProcedures.Properties.Items.AddRange(_service.GetAllProcedures().ToArray());

            Query();
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            var dlg = new AddProduceRecordForm();
            {
                dlg.DataSaved += (s, arg) => Query(dlg);
                dlg.DataSaved += (s, arg) =>
                {
                    Query(dlg);
                    var id = arg?.ProduceRecord?.Id;
                    if (id.HasValue)
                        JumpTo(id.Value);
                };
                dlg.ShowDialog();
            }
        }

        private void _btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void Query(Form target = null)
        {
            using (WaitHelper.ShowWaitForm("加载中。。。", target))
            {
                var currentProduceRecordId = GetFocusedProduceRecordId();

                var procedures = (_cbProcedures.Properties.Items.Where(x => x.CheckState == CheckState.Checked).Select(x => x.Value as Procedure))?.Select(x => x.Id)?.ToList() ?? new List<int>();

                var keyword = textEdit1.Text;

                var minDate = new DateTime(2000, 1, 1);
                var startTime = dateEdit1.DateTime < minDate ? minDate : dateEdit1.DateTime;
                var endTime = dateEdit2.DateTime < minDate ? DateTime.MaxValue : dateEdit2.DateTime.AddDays(1).AddSeconds(-1);

                gridControl.DataSource = produceRecordList = _service.GetAllProduceRecords()
                    .Where(x => (!procedures.Any() || procedures.Contains(x.ProcedureId))
                        && (string.IsNullOrWhiteSpace(keyword) || x.WorkerName.Contains(keyword) || x.ProductName.Contains(keyword))
                        && (x.Date >= startTime && x.Date <= endTime))
                    .ToList();
                JumpTo(currentProduceRecordId);
            }
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
                    dlg.DataSaved += (s, arg) =>
                    {
                        Query(dlg);
                        var id = arg?.ProduceRecord?.Id;
                        if (id.HasValue)
                            JumpTo(id.Value);
                    };

                    dlg.ShowDialog();
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
                else if (batchViewModel.IsProductDeleted)
                    e.DisplayText = "产品已删除";
                else if (batchViewModel.IsProcedureDeleted)
                    e.DisplayText = "工序已删除";
                else if (batchViewModel.IsWorkerDeleted)
                    e.DisplayText = "工人已删除";
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
            if (parameter is int batchId)
            {
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
