﻿namespace ProduceManager.Forms
{
    partial class ProductListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListView));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this._gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colOperation = new DevExpress.XtraGrid.Columns.GridColumn();
            this._riOperation = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this._btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this._btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this._colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colState = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl.Size = new System.Drawing.Size(938, 555);
            this.gridControl.TabIndex = 6;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gridView});
            // 
            // _gridView
            // 
            this._gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this._gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._colId,
            this._colProductName,
            this._colCode,
            this._colState,
            this._colOperation});
            this._gridView.GridControl = this.gridControl;
            this._gridView.Name = "_gridView";
            this._gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this._gridView_CustomColumnDisplayText);
            // 
            // _colProductName
            // 
            this._colProductName.Caption = "产品名称";
            this._colProductName.FieldName = "Name";
            this._colProductName.Name = "_colProductName";
            this._colProductName.Visible = true;
            this._colProductName.VisibleIndex = 1;
            this._colProductName.Width = 696;
            // 
            // _colId
            // 
            this._colId.Caption = "Id";
            this._colId.FieldName = "Id";
            this._colId.Name = "_colId";
            this._colId.Visible = true;
            this._colId.VisibleIndex = 0;
            this._colId.Width = 73;
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
            this._colOperation.VisibleIndex = 4;
            this._colOperation.Width = 151;
            // 
            // _riOperation
            // 
            this._riOperation.AutoHeight = false;
            this._riOperation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "明细", 0, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("_riOperation.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("_riOperation.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", 0, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("_riOperation.Buttons2"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, "", null, null, true)});
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
            this.panelControl1.Size = new System.Drawing.Size(938, 41);
            this.panelControl1.TabIndex = 7;
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
            this._btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("_btnAdd.Image")));
            this._btnAdd.Location = new System.Drawing.Point(868, 7);
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
            this._btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("_btnQuery.Image")));
            this._btnQuery.Location = new System.Drawing.Point(804, 8);
            this._btnQuery.Name = "_btnQuery";
            this._btnQuery.Size = new System.Drawing.Size(58, 28);
            this._btnQuery.TabIndex = 0;
            this._btnQuery.Text = "查询";
            this._btnQuery.Click += new System.EventHandler(this._btnQuery_Click);
            // 
            // _colCode
            // 
            this._colCode.Caption = "编码";
            this._colCode.FieldName = "Code";
            this._colCode.Name = "_colCode";
            this._colCode.Visible = true;
            this._colCode.VisibleIndex = 2;
            // 
            // _colState
            // 
            this._colState.Caption = "状态";
            this._colState.Name = "_colState";
            this._colState.Visible = true;
            this._colState.VisibleIndex = 3;
            // 
            // ProductListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "ProductListView";
            this.Size = new System.Drawing.Size(938, 596);
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
        private DevExpress.XtraGrid.Columns.GridColumn _colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn _colId;
        private DevExpress.XtraGrid.Columns.GridColumn _colOperation;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit _riOperation;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton _btnAdd;
        private DevExpress.XtraEditors.SimpleButton _btnQuery;
        private DevExpress.XtraGrid.Columns.GridColumn _colCode;
        private DevExpress.XtraGrid.Columns.GridColumn _colState;
    }
}
