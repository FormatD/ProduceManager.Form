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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleBillView));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this._btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this._btnQuery = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._riOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
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
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            editorButtonImageOptions1.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            editorButtonImageOptions2.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this._riOperation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", 0, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this._riOperation.Name = "_riOperation";
            this._riOperation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this._riOperation.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this._riOperation_ButtonClick);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.dateEdit1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this._btnAdd);
            this.panelControl1.Controls.Add(this._btnQuery);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1023, 41);
            this.panelControl1.TabIndex = 9;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(242, 11);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(144, 20);
            this.dateEdit1.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(179, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "开始时间";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "关键字";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(55, 11);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
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
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton _btnAdd;
        private DevExpress.XtraEditors.SimpleButton _btnQuery;
        private DevExpress.XtraGrid.Columns.GridColumn _colTotalPrice;
    }
}
