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
    public partial class AddWorkerForm : XtraForm
    {
        private readonly int _workerId;
        private readonly bool _isAddingNew;
        readonly ApplicationService _service;
        public AddWorkerForm()
        {
            _service = ApplicationService.Instanse;
            InitializeComponent();
            _isAddingNew = true;
        }

        public AddWorkerForm(int workerId)
        {
            _service = ApplicationService.Instanse;
            InitializeComponent();
            this._workerId = workerId;

            Text = "编辑工人";
            _btnAdd.Text = "保存";

            var worker = _service.GetWorker(_workerId);
            _txtCode.Text = worker.Code;
            _txtName.Text = worker.Name;
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
                var worker = new Worker
                {
                    Name = name,
                    Code = code,
                };
                _service.AddWorker(worker);
            }
            else
            {
                var oldBatch = _service.GetWorker(_workerId);

                oldBatch.Name = name;
                oldBatch.Code = code;

                _service.SaveChanges();
            }

            DialogResult = DialogResult.OK;
        }
    }
}