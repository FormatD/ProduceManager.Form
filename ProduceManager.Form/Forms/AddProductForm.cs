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

namespace ProduceManager.Forms
{
    public partial class AddProductForm : XtraForm
    {
        private int _productId;
        private bool _isAddingNew;
        ApplicationService _service;
        public AddProductForm()
        {
            _service = ApplicationService.Instanse;
            InitializeComponent();
            _isAddingNew = true;
        }

        public AddProductForm(int productId)
        {
            _service = ApplicationService.Instanse;
            InitializeComponent();
            _productId = productId;

            Text = "编辑产品";
            _btnAdd.Text = "保存";

            var product = _service.GetProduct(_productId);
            _txtCode.Text = product.Code;
            _txtName.Text = product.Name;
        }

        private void AddBatchForm_Load(object sender, EventArgs e)
        {
            // 加载完成之后挂事件
            _txtName.EditValueChanged += _txtName_EditValueChanged;
        }

        private void _txtName_EditValueChanged(object sender, EventArgs e)
        {
            _txtCode.Text = PinYinHelper.GetPinYinFirstChars(_txtName.Text);
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            //var procedures = _chkProcedures.
            var name = _txtName.Text;
            var code = _txtCode.Text;

            if (_isAddingNew)
            {
                var product = new Product
                {
                    Name = name,
                    Code = code,
                };
                _service.AddProduct(product);
            }
            else
            {
                var oldBatch = _service.GetProduct(_productId);

                oldBatch.Name = name;
                oldBatch.Code = code;

                _service.SaveChanges();
            }

            DialogResult = DialogResult.OK;
        }
    }
}