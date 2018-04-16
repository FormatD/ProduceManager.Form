using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ProduceManager.Forms.Persistence;
using ProduceManager.Forms.Domains;
using ProduceManager.Forms.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.Filtering;
using System.Threading;

namespace ProduceManager.Forms
{
    public partial class AddProduceRecordForm : XtraForm
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
        private bool _isBatchMode;

        public event EventHandler<AddProduceRecordEventArgs> DataSaved;

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

        void Properties_PopupFilter(object sender, DevExpress.XtraEditors.Controls.PopupFilterEventArgs e)
        {
            if (string.IsNullOrEmpty(e.SearchText)) return;
            LookUpEdit edit = sender as LookUpEdit;
            PropertyDescriptorCollection propertyDescriptors = ListBindingHelper.GetListItemProperties(edit.Properties.DataSource);
            IEnumerable<FunctionOperator> operators = propertyDescriptors.OfType<PropertyDescriptor>().Select(
                t => new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(t.Name), new OperandValue(e.SearchText)));
            e.Criteria = new GroupOperator(GroupOperatorType.Or, operators);
            e.SuppressSearchCriteria = true;
        }

        private void AddProduceRecordForm_Load(object sender, EventArgs e)
        {
            _cbProducts.Properties.DataSource = _productList = _service.GetAllProducts();
            _cbProducts.Properties.TextEditStyle = TextEditStyles.Standard;
            _cbProducts.Properties.ImmediatePopup = true;
            _cbProducts.Properties.DisplayMember = "Name";
            _cbProducts.Properties.ValueMember = "Id";

            _cbProducts.Properties.PopupFilter += Properties_PopupFilter;

            _cbBatch.Properties.DataSource = _batchList = _service.GetAllBatches();
            _cbBatch.Properties.TextEditStyle = TextEditStyles.Standard;
            _cbBatch.Properties.ImmediatePopup = true;
            _cbBatch.Properties.DisplayMember = "BatchNo";
            _cbBatch.Properties.ValueMember = "Id";

            _cbProcedure.Properties.DataSource = _procedureList = _service.GetAllProcedures();
            _cbProcedure.Properties.TextEditStyle = TextEditStyles.Standard;
            _cbProcedure.Properties.ImmediatePopup = true;
            _cbProcedure.Properties.DisplayMember = "DisplayText";
            _cbProcedure.Properties.ValueMember = "Id";

            _cbWorkers.Properties.DataSource = _workerList = _service.GetAllWorkers();
            _cbWorkers.Properties.TextEditStyle = TextEditStyles.Standard;
            _cbWorkers.Properties.ImmediatePopup = true;
            _cbWorkers.Properties.DisplayMember = "DisplayText";
            _cbWorkers.Properties.ValueMember = "Id";

            if (_isAddingNew)
            {
                if (_addFromBatch)
                {
                    _cbBatch.ItemIndex = _batchList.IndexOf(x => x.Id == _batchId);
                }

                _deStartTime.EditValue = DateTime.Today;
            }
            else
            {
                var produceRecord = _service.GetProduceRecord(_produceRecordId);
                if (produceRecord == null)
                {
                    MessageBoxHelper.Warn("生产明细不存在。");
                    DialogResult = DialogResult.Abort;
                    return;
                }

                _cbBatch.ItemIndex = _batchList.IndexOf(x => x.Id == produceRecord.BatchId);
                //_cbProducts.ItemIndex = _productList.IndexOf(x => x.Id == produceRecord.ProductId);
                _cbWorkers.EditValue = _workerList.FirstOrDefault(x => x.Id == produceRecord.WorkerId);
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

            if (!_cbProcedure.Validate(procedure == null)
                || !_cbProducts.Validate(product == null)
                || !_cbWorkers.Validate(worker == null)
                || !_seExpectedAmount.Validate(amount <= 0)
                || !_deStartTime.Validate(date < new DateTime(1990, 1, 1)))
            {
                return;
            }

            if (_isAddingNew)
            {
                //var procedures = _chkProcedures.
                var produceRecord = new ProduceRecord
                {
                    WorkerId = worker.Id,
                    BatchId = 0,//batch.Id,
                    ProductId = product.Id,// batch.ProductId,
                    ProcedureId = procedure.Id,
                    Amount = amount,
                    Date = date,
                };
                _service.AddProduceRecord(produceRecord);
                OnDataSaved(produceRecord);
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
                OnDataSaved(oldProduceRecord);
            }

            SetAsFocused();

            if (_chkIsBatchAddModel.Checked)
            {
                ResetForm();
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void SetAsFocused()
        {
            ThreadPool.QueueUserWorkItem(x =>
            {
                Thread.Sleep(500);
                BeginInvoke(new MethodInvoker(() =>
                {
                    var xx = Win32Helper.SetForegroundWindow(this.Handle);
                    Console.WriteLine(xx);
                }));
            });

            //this.Activate();

            //Console.WriteLine(this.Focus());
            //Console.WriteLine(this.TopMost = true);
            //Console.WriteLine($"Current is me:{Form.ActiveForm == this}");
        }

        private void ResetForm()
        {
            _cbProducts.Select();
            //_deStartTime.EditValue = DateTime.Today;
            _seExpectedAmount.EditValue = 0;
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

        private void _chkIsBatchAddModel_CheckedChanged(object sender, EventArgs e)
        {
            _isBatchMode = _chkIsBatchAddModel.Checked;

            _cbBatch.TabStop = !_isBatchMode;
            _cbProcedure.TabStop = !_isBatchMode;
            _deStartTime.TabStop = !_isBatchMode;

            _cbBatch.Properties.Appearance.BackColor = _isBatchMode ? Color.Gray : Color.White;
            _cbProcedure.Properties.Appearance.BackColor = _isBatchMode ? Color.Gray : Color.White;
            _deStartTime.Properties.Appearance.BackColor = _isBatchMode ? Color.Gray : Color.White;
        }

        private void OnDataSaved(ProduceRecord produceRecord)
        {
            var handler = DataSaved;
            DataSaved?.Invoke(this, new AddProduceRecordEventArgs { ProduceRecord = produceRecord });
        }
    }

    public class AddProduceRecordEventArgs : EventArgs
    {
        public ProduceRecord ProduceRecord { get; set; }
    }

    public static class FormValidateHelper
    {
        public static bool Validate(this Control control, bool failCondition)
        {
            if (failCondition)
            {
                control.Select();
                return false;
            }

            return true;
        }
    }
}