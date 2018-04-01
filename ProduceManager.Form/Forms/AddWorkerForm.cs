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
    public partial class AddWorkerForm : DevExpress.XtraEditors.XtraForm
    {
        private int _workerId;
        private bool _isAddingNew;
        ApplicationService _service;
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