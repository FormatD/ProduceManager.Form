﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ProduceManager.Core.Persistence;
using ProduceManager.Core.Domains;
using ProduceManager.Forms.Utils;

namespace ProduceManager.Forms
{
    public partial class AddProcedureForm : XtraForm
    {
        private readonly int _procedureId;
        private readonly bool _isAddingNew;
        readonly ApplicationService _service;
        public AddProcedureForm()
        {
            _service = ApplicationService.Instanse;
            InitializeComponent();
            _isAddingNew = true;
        }

        public AddProcedureForm(int procedureId)
        {
            _service = ApplicationService.Instanse;
            InitializeComponent();
            this._procedureId = procedureId;

            Text = "编辑产品";
            _btnAdd.Text = "保存";

            var procedure = _service.GetProcedure(_procedureId);
            //_txtCode.Text = procedure.Code;
            _txtName.Text = procedure.Name;
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
                var procedure = new Procedure
                {
                    Name = name,
                    //Code = code,
                    CanSetPrice = _chkCanSetPrice.Checked,
                };
                _service.AddProcedure(procedure);
            }
            else
            {
                var oldBatch = _service.GetProcedure(_procedureId);

                oldBatch.Name = name;
                oldBatch.CanSetPrice = _chkCanSetPrice.Checked;

                _service.SaveChanges();
            }

            DialogResult = DialogResult.OK;
        }
    }
}