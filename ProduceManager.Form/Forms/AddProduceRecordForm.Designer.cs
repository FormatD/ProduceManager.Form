namespace ProduceManager.Forms
{
    partial class AddProduceRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduceRecordForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this._chkIsBatchAddModel = new DevExpress.XtraEditors.CheckEdit();
            this._btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this._btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this._cbBatch = new DevExpress.XtraEditors.LookUpEdit();
            this._cbProcedure = new DevExpress.XtraEditors.LookUpEdit();
            this._cbProducts = new DevExpress.XtraEditors.LookUpEdit();
            this._deStartTime = new DevExpress.XtraEditors.DateEdit();
            this._seExpectedAmount = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this._cbWorkers = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsBatchAddModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cbBatch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbProcedure.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbProducts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deStartTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._seExpectedAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbWorkers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this._chkIsBatchAddModel);
            this.panelControl1.Controls.Add(this._btnCancel);
            this.panelControl1.Controls.Add(this._btnAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 251);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(467, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // _chkIsBatchAddModel
            // 
            this._chkIsBatchAddModel.Location = new System.Drawing.Point(13, 11);
            this._chkIsBatchAddModel.Name = "_chkIsBatchAddModel";
            this._chkIsBatchAddModel.Properties.Caption = "批量添加模式";
            this._chkIsBatchAddModel.Size = new System.Drawing.Size(114, 19);
            this._chkIsBatchAddModel.TabIndex = 2;
            this._chkIsBatchAddModel.CheckedChanged += new System.EventHandler(this._chkIsBatchAddModel_CheckedChanged);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(307, 11);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(64, 23);
            this._btnCancel.TabIndex = 1;
            this._btnCancel.Text = "取消(&C)";
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnAdd
            // 
            this._btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnAdd.Location = new System.Drawing.Point(383, 11);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(64, 23);
            this._btnAdd.TabIndex = 0;
            this._btnAdd.Text = "添加(&A)";
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this._cbBatch);
            this.panelControl2.Controls.Add(this._cbProcedure);
            this.panelControl2.Controls.Add(this._cbProducts);
            this.panelControl2.Controls.Add(this._deStartTime);
            this.panelControl2.Controls.Add(this._seExpectedAmount);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this._cbWorkers);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(467, 251);
            this.panelControl2.TabIndex = 2;
            // 
            // _cbBatch
            // 
            this._cbBatch.Location = new System.Drawing.Point(135, 21);
            this._cbBatch.Name = "_cbBatch";
            this._cbBatch.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this._cbBatch.Properties.Appearance.Options.UseBackColor = true;
            this._cbBatch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._cbBatch.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("No", "批次号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Date", "开始时间", 20, DevExpress.Utils.FormatType.DateTime, "yyyy-MM-dd", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this._cbBatch.Properties.NullText = "请选择产品";
            this._cbBatch.Size = new System.Drawing.Size(267, 20);
            this._cbBatch.TabIndex = 0;
            this._cbBatch.EditValueChanged += new System.EventHandler(this._cbBatch_EditValueChanged);
            // 
            // _cbProcedure
            // 
            this._cbProcedure.Location = new System.Drawing.Point(135, 59);
            this._cbProcedure.Name = "_cbProcedure";
            this._cbProcedure.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this._cbProcedure.Properties.Appearance.Options.UseBackColor = true;
            this._cbProcedure.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._cbProcedure.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Blue;
            this._cbProcedure.Properties.AppearanceFocused.Options.UseBackColor = true;
            this._cbProcedure.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this._cbProcedure.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._cbProcedure.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayText", "工序名称")});
            this._cbProcedure.Properties.NullText = "请选择工序";
            this._cbProcedure.Size = new System.Drawing.Size(267, 20);
            this._cbProcedure.TabIndex = 1;
            // 
            // _cbProducts
            // 
            this._cbProducts.Location = new System.Drawing.Point(135, 170);
            this._cbProducts.Name = "_cbProducts";
            this._cbProducts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._cbProducts.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "产品名称")});
            this._cbProducts.Properties.NullText = "请选择产品";
            this._cbProducts.Size = new System.Drawing.Size(267, 20);
            this._cbProducts.TabIndex = 4;
            // 
            // _deStartTime
            // 
            this._deStartTime.EditValue = null;
            this._deStartTime.Location = new System.Drawing.Point(135, 96);
            this._deStartTime.Name = "_deStartTime";
            this._deStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._deStartTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._deStartTime.Size = new System.Drawing.Size(267, 20);
            this._deStartTime.TabIndex = 2;
            // 
            // _seExpectedAmount
            // 
            this._seExpectedAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._seExpectedAmount.Location = new System.Drawing.Point(135, 206);
            this._seExpectedAmount.Name = "_seExpectedAmount";
            this._seExpectedAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._seExpectedAmount.Size = new System.Drawing.Size(267, 20);
            this._seExpectedAmount.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(58, 207);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "生产数量";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(82, 136);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "工人";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(82, 172);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "产品";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(82, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "工序";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(58, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "生产时间";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(70, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "批次号";
            // 
            // _cbWorkers
            // 
            this._cbWorkers.Location = new System.Drawing.Point(135, 135);
            this._cbWorkers.Name = "_cbWorkers";
            this._cbWorkers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._cbWorkers.Properties.NullText = "请选择工人";
            this._cbWorkers.Properties.PopupView = this.gridLookUpEdit1View;
            this._cbWorkers.Size = new System.Drawing.Size(267, 20);
            this._cbWorkers.TabIndex = 3;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // AddProduceRecordForm
            // 
            this.AcceptButton = this._btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(467, 297);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduceRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加生产明细";
            this.Load += new System.EventHandler(this.AddProduceRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._chkIsBatchAddModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cbBatch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbProcedure.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbProducts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deStartTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._seExpectedAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbWorkers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit _deStartTime;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit _cbProducts;
        private DevExpress.XtraEditors.LookUpEdit _cbProcedure;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit _cbBatch;
        private DevExpress.XtraEditors.CheckEdit _chkIsBatchAddModel;
        private DevExpress.XtraEditors.GridLookUpEdit _cbWorkers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}