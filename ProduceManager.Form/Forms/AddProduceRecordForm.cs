using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ProduceManager.Form.Persistence;
using ProduceManager.Form.Domains;
using ProduceManager.Form.Utils;

namespace ProduceManager.Form
{
    public partial class AddProduceRecordForm : DevExpress.XtraEditors.XtraForm
    {
        private bool _isAddingNew;
        private int _produceRecordId;
        ApplicationService _service = ApplicationService.Instanse;
        private IList<Product> _productList;
        private IList<BatchViewModel> _batchList;
        private IList<Procedure> _procedureList;
        private IList<Worker> _workerList;
        private int _batchId;
        private bool _addFromBatch;
        public AddProduceRecordForm()
        {
            InitializeComponent();
            _isAddingNew = true;
            Text = "添加生产明细";
        }

        public AddProduceRecordForm(BatchViewModel batchViewModel)
            : this()
        {
            _batchId = batchViewModel.Id;
            _addFromBatch = true;
        }

        public AddProduceRecordForm(int produceRecordId)
        {
            InitializeComponent();
            _produceRecordId = produceRecordId;
            Text = "编辑生产明细";
            _btnAdd.Text = "保存";
        }

        private void AddProduceRecordForm_Load(object sender, EventArgs e)
        {
            _cbProducts.Properties.DataSource = _productList = _service.GetAllProducts();
            _cbProducts.Properties.DisplayMember = "Name";
            _cbProducts.Properties.ValueMember = "Id";
            //_cbProducts.Properties.re = false;

            _cbBatch.Properties.DataSource = _batchList = _service.GetAllBatches();
            _cbBatch.Properties.DisplayMember = "BatchNo";
            _cbBatch.Properties.ValueMember = "Id";

            _cbProcedure.Properties.DataSource = _procedureList = _service.GetAllProcedures();
            _cbProcedure.Properties.DisplayMember = "Name";
            _cbProcedure.Properties.ValueMember = "Id";

            _cbWorkers.Properties.DataSource = _workerList = _service.GetAllWorkers();
            _cbWorkers.Properties.DisplayMember = "Name";
            _cbWorkers.Properties.ValueMember = "Id";

            if (_addFromBatch)
            {
                _cbBatch.ItemIndex = _batchList.IndexOf(x => x.Id == _batchId);
            }

            if (_isAddingNew)
            {
            }
            else
            {
                var produceRecord = _service.GetProduceRecord(_produceRecordId);
                if (produceRecord == null)
                {
                    MessageBoxHelper.Warn("生产明细不存在。");
                    DialogResult = System.Windows.Forms.DialogResult.Abort;
                    return;
                }

                //_cbProducts.ItemIndex = _productList.IndexOf(x => x.Id == produceRecord.ProductId);
                _cbWorkers.ItemIndex = _workerList.IndexOf(x => x.Id == produceRecord.WorkerId);
                _cbProcedure.ItemIndex = _productList.IndexOf(x => x.Id == produceRecord.ProcedureId);
                _seExpectedAmount.EditValue = produceRecord.Amount;
                _deStartTime.EditValue = produceRecord.Date;
            }
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            var batch = _cbBatch.GetSelectedDataRow() as BatchViewModel;
            var product = _cbProducts.GetSelectedDataRow() as Product;
            var worker = _cbWorkers.GetSelectedDataRow() as Worker;
            var procedure = _cbProcedure.GetSelectedDataRow() as Procedure;

            var amount = (int)_seExpectedAmount.Value;
            var date = _deStartTime.DateTime;

            if (_isAddingNew)
            {
                //var procedures = _chkProcedures.
                var produceRecord = new ProduceRecord
                {
                    WorkerId = worker.Id,
                    BatchId = batch.Id,
                    ProductId = batch.ProductId,
                    ProcedureId = procedure.Id,
                    Amount = amount,
                    Date = date,
                };
                _service.AddProduceRecord(produceRecord);
            }
            else
            {
                var oldProduceRecord = _service.GetProduceRecord(_produceRecordId);

                oldProduceRecord.Amount = amount;
                oldProduceRecord.BatchId = batch.Id;
                oldProduceRecord.ProductId = batch.ProductId;
                oldProduceRecord.WorkerId = worker.Id;
                oldProduceRecord.ProcedureId = procedure.Id;
                _deStartTime.DateTime = date;

                _service.SaveChanges();
            }
            DialogResult = DialogResult.OK;
        }

        private void _cbBatch_EditValueChanged(object sender, EventArgs e)
        {
            var batch = _cbBatch.GetSelectedDataRow() as BatchViewModel;
            if (batch == null)
                _cbProducts.ItemIndex = -1;
            else
            {
                var index = _productList.IndexOf(x => x.Id == batch.ProductId);
                _cbProducts.ItemIndex = index;
            }
        }

    }
}