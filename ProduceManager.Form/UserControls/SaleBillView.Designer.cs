namespace ProduceManager.Forms.UserControls
{
    partial class SaleBillView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleBillView));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this._gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colCustomName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colOperation = new DevExpress.XtraGrid.Columns.GridColumn();
            this._riOperation = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this._txtKeyword = new DevExpress.XtraEditors.TextEdit();
            this._btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this._btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this._deEnd = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this._deStart = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._riOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtKeyword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deStart.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 41);
            this.gridControl.MainView = this._gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this._riOperation});
            this.gridControl.Size = new System.Drawing.Size(1023, 548);
            this.gridControl.TabIndex = 8;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gridView});
            // 
            // _gridView
            // 
            this._gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this._gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._colId,
            this._colCustomName,
            this._colCode,
            this._colState,
            this._colTotalPrice,
            this._colOperation});
            this._gridView.GridControl = this.gridControl;
            this._gridView.Name = "_gridView";
            // 
            // _colId
            // 
            this._colId.Caption = "Id";
            this._colId.FieldName = "Id";
            this._colId.Name = "_colId";
            this._colId.Visible = true;
            this._colId.VisibleIndex = 0;
            this._colId.Width = 63;
            // 
            // _colCustomName
            // 
            this._colCustomName.Caption = "客户名称";
            this._colCustomName.FieldName = "CustomeName";
            this._colCustomName.Name = "_colCustomName";
            this._colCustomName.Visible = true;
            this._colCustomName.VisibleIndex = 2;
            this._colCustomName.Width = 401;
            // 
            // _colCode
            // 
            this._colCode.Caption = "销售单号";
            this._colCode.FieldName = "BillNo";
            this._colCode.Name = "_colCode";
            this._colCode.Visible = true;
            this._colCode.VisibleIndex = 1;
            this._colCode.Width = 176;
            // 
            // _colState
            // 
            this._colState.Caption = "状态";
            this._colState.Name = "_colState";
            this._colState.Visible = true;
            this._colState.VisibleIndex = 4;
            this._colState.Width = 110;
            // 
            // _colTotalPrice
            // 
            this._colTotalPrice.Caption = "总价";
            this._colTotalPrice.FieldName = "TotalPrice";
            this._colTotalPrice.Name = "_colTotalPrice";
            this._colTotalPrice.Visible = true;
            this._colTotalPrice.VisibleIndex = 3;
            this._colTotalPrice.Width = 114;
            // 
            // _colOperation
            // 
            this._colOperation.AppearanceCell.Options.UseTextOptions = true;
            this._colOperation.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._colOperation.AppearanceHeader.Options.UseTextOptions = true;
            this._colOperation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._colOperation.Caption = "操作";
            this._colOperation.ColumnEdit = this._riOperation;
            this._colOperation.Name = "_colOperation";
            this._colOperation.Visible = true;
            this._colOperation.VisibleIndex = 5;
            this._colOperation.Width = 141;
            // 
            // _riOperation
            // 
            this._riOperation.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            editorButtonImageOptions3.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            editorButtonImageOptions4.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this._riOperation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", 0, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this._riOperation.Name = "_riOperation";
            this._riOperation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this._riOperation.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this._riOperation_ButtonClick);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this._deEnd);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this._deStart);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this._txtKeyword);
            this.panelControl1.Controls.Add(this._btnAdd);
            this.panelControl1.Controls.Add(this._btnQuery);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1023, 41);
            this.panelControl1.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "关键字";
            // 
            // _txtKeyword
            // 
            this._txtKeyword.Location = new System.Drawing.Point(55, 11);
            this._txtKeyword.Name = "_txtKeyword";
            this._txtKeyword.Size = new System.Drawing.Size(100, 20);
            this._txtKeyword.TabIndex = 1;
            // 
            // _btnAdd
            // 
            this._btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAdd.Appearance.Options.UseTextOptions = true;
            this._btnAdd.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this._btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnAdd.ImageOptions.Image")));
            this._btnAdd.Location = new System.Drawing.Point(953, 7);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(58, 28);
            this._btnAdd.TabIndex = 0;
            this._btnAdd.Text = "添加";
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _btnQuery
            // 
            this._btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnQuery.Appearance.Options.UseTextOptions = true;
            this._btnQuery.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this._btnQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnQuery.ImageOptions.Image")));
            this._btnQuery.Location = new System.Drawing.Point(889, 8);
            this._btnQuery.Name = "_btnQuery";
            this._btnQuery.Size = new System.Drawing.Size(58, 28);
            this._btnQuery.TabIndex = 0;
            this._btnQuery.Text = "查询";
            this._btnQuery.Click += new System.EventHandler(this._btnQuery_Click);
            // 
            // _deEnd
            // 
            this._deEnd.EditValue = null;
            this._deEnd.Location = new System.Drawing.Point(355, 10);
            this._deEnd.Name = "_deEnd";
            this._deEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._deEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._deEnd.Size = new System.Drawing.Size(101, 20);
            this._deEnd.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(337, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(12, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "到";
            // 
            // _deStart
            // 
            this._deStart.EditValue = null;
            this._deStart.Location = new System.Drawing.Point(235, 10);
            this._deStart.Name = "_deStart";
            this._deStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._deStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._deStart.Size = new System.Drawing.Size(101, 20);
            this._deStart.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(172, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "订单时间从";
            // 
            // SaleBillView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "SaleBillView";
            this.Size = new System.Drawing.Size(1023, 589);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._riOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtKeyword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deStart.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView _gridView;
        private DevExpress.XtraGrid.Columns.GridColumn _colId;
        private DevExpress.XtraGrid.Columns.GridColumn _colCustomName;
        private DevExpress.XtraGrid.Columns.GridColumn _colCode;
        private DevExpress.XtraGrid.Columns.GridColumn _colState;
        private DevExpress.XtraGrid.Columns.GridColumn _colOperation;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit _riOperation;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit _txtKeyword;
        private DevExpress.XtraEditors.SimpleButton _btnAdd;
        private DevExpress.XtraEditors.SimpleButton _btnQuery;
        private DevExpress.XtraGrid.Columns.GridColumn _colTotalPrice;
        private DevExpress.XtraEditors.DateEdit _deEnd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit _deStart;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
