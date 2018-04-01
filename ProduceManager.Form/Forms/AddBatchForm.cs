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
    public partial class AddBatchForm : DevExpress.XtraEditors.XtraForm
    {
        private bool _isAddingNew;
        private int _batchId;
        ApplicationService _service;
        private IList<Product> _productList;
        public AddBatchForm()
        {
            InitializeComponent();
            _isAddingNew = true;
        }

        public AddBatchForm(int batchId)
        {
            InitializeComponent();
            _batchId = batchId;
        }

        private void AddBatchForm_Load(object sender, EventArgs e)
        {
            _service = ApplicationService.Instanse;

            _cbProducts.Properties.DataSource = _productList = ApplicationService.Instanse.GetAllProducts();
            _cbProducts.Properties.DisplayMember = "Name";
            _cbProducts.Properties.ValueMember = "Id";

            if (_isAddingNew)
            {
                _txtBatchNo.Text = SequenseNoGenerator.GetNextCode();

                Text = "添加批次";
            }
            else
            {
                var batch = _service.GetBatch(_batchId);
                if (batch == null)
                {
                    MessageBoxHelper.Warn("批次不存在。");
                    DialogResult = System.Windows.Forms.DialogResult.Abort;
                    return;
                }

                var product = _productList.FirstOrDefault(x => x.Id == batch.ProductId);

                _cbProducts.ItemIndex = product == null ? -1 : _productList.IndexOf(product);
                _txtBatchNo.Text = batch.No;
                _seExpectedAmount.Value = batch.ExpectedAmount;

                Text = "编辑批次";
                _btnAdd.Text = "保存";
            }
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            var product = _cbProducts.GetSelectedDataRow() as Product;
            var amount = (int)_seExpectedAmount.Value;

            if (_isAddingNew)
            {
                //var procedures = _chkProcedures.
                var batch = new Batch
                {
                    No = _txtBatchNo.Text,
                    ProductId = product.Id,
                    ExpectedAmount = amount,
                    StartDate = DateTime.Now.Date,
                };
                _service.AddBatch(batch);
            }
            else
            {
                var oldBatch = _service.GetBatch(_batchId);

                oldBatch.ExpectedAmount = amount;
                oldBatch.ProductId = product.Id;

                _service.SaveChanges();
            }
            DialogResult = DialogResult.OK;
        }

    }
}