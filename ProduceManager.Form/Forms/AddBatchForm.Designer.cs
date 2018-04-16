namespace ProduceManager.Forms
{
    partial class AddBatchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBatchForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this._btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this._btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this._cbProducts = new DevExpress.XtraEditors.LookUpEdit();
            this._deStartTime = new DevExpress.XtraEditors.DateEdit();
            this._chkProcedures = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this._seExpectedAmount = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this._txtBatchNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cbProducts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deStartTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkProcedures.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._seExpectedAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtBatchNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this._btnCancel);
            this.panelControl1.Controls.Add(this._btnAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 221);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(449, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(289, 11);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(64, 23);
            this._btnCancel.TabIndex = 1;
            this._btnCancel.Text = "取消(&C)";
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnAdd
            // 
            this._btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnAdd.Location = new System.Drawing.Point(365, 11);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(64, 23);
            this._btnAdd.TabIndex = 0;
            this._btnAdd.Text = "添加(&A)";
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this._cbProducts);
            this.panelControl2.Controls.Add(this._deStartTime);
            this.panelControl2.Controls.Add(this._chkProcedures);
            this.panelControl2.Controls.Add(this._seExpectedAmount);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this._txtBatchNo);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(449, 221);
            this.panelControl2.TabIndex = 2;
            // 
            // _cbProducts
            // 
            this._cbProducts.Location = new System.Drawing.Point(135, 60);
            this._cbProducts.Name = "_cbProducts";
            this._cbProducts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._cbProducts.Properties.NullText = "请选择产品";
            this._cbProducts.Size = new System.Drawing.Size(251, 20);
            this._cbProducts.TabIndex = 1;
            // 
            // _deStartTime
            // 
            this._deStartTime.EditValue = null;
            this._deStartTime.Location = new System.Drawing.Point(135, 97);
            this._deStartTime.Name = "_deStartTime";
            this._deStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._deStartTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._deStartTime.Size = new System.Drawing.Size(251, 20);
            this._deStartTime.TabIndex = 2;
            // 
            // _chkProcedures
            // 
            this._chkProcedures.Location = new System.Drawing.Point(135, 139);
            this._chkProcedures.Name = "_chkProcedures";
            this._chkProcedures.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._chkProcedures.Size = new System.Drawing.Size(251, 20);
            this._chkProcedures.TabIndex = 3;
            // 
            // _seExpectedAmount
            // 
            this._seExpectedAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._seExpectedAmount.Location = new System.Drawing.Point(135, 180);
            this._seExpectedAmount.Name = "_seExpectedAmount";
            this._seExpectedAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._seExpectedAmount.Size = new System.Drawing.Size(251, 20);
            this._seExpectedAmount.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(34, 181);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "预期生产数量";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(82, 60);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "产品";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(82, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "工序";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "开始生产时间";
            // 
            // _txtBatchNo
            // 
            this._txtBatchNo.Location = new System.Drawing.Point(135, 21);
            this._txtBatchNo.Name = "_txtBatchNo";
            this._txtBatchNo.Properties.ReadOnly = true;
            this._txtBatchNo.Size = new System.Drawing.Size(251, 20);
            this._txtBatchNo.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(66, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = " 批次号";
            // 
            // AddBatchForm
            // 
            this.AcceptButton = this._btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(449, 267);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加批次";
            this.Load += new System.EventHandler(this.AddBatchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cbProducts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deStartTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkProcedures.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._seExpectedAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtBatchNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton _btnCancel;
        private DevExpress.XtraEditors.SimpleButton _btnAdd;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SpinEdit _seExpectedAmount;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit _txtBatchNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit _chkProcedures;
        private DevExpress.XtraEditors.DateEdit _deStartTime;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit _cbProducts;
    }
}