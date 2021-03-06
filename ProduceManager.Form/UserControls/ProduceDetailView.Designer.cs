﻿namespace ProduceManager.Forms
{
    partial class ProduceDetailView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProduceDetailView));
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
            this._colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colProcedure = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colWorker = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colOperation = new DevExpress.XtraGrid.Columns.GridColumn();
            this._riOperate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this._cbProcedures = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this._btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this._btnQuery = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._riOperate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cbProcedures.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
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
            this._riOperate});
            this.gridControl.Size = new System.Drawing.Size(1032, 615);
            this.gridControl.TabIndex = 8;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gridView});
            // 
            // _gridView
            // 
            this._gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this._gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._colDate,
            this._colProductName,
            this._colProcedure,
            this._colWorker,
            this._colAmount,
            this._colState,
            this._colTotalPrice,
            this._colOperation});
            this._gridView.GridControl = this.gridControl;
            this._gridView.Name = "_gridView";
            this._gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this._gridView_CustomColumnDisplayText);
            // 
            // _colDate
            // 
            this._colDate.Caption = "日期";
            this._colDate.FieldName = "Date";
            this._colDate.Name = "_colDate";
            this._colDate.Visible = true;
            this._colDate.VisibleIndex = 0;
            this._colDate.Width = 141;
            // 
            // _colProductName
            // 
            this._colProductName.Caption = "产品";
            this._colProductName.FieldName = "ProductName";
            this._colProductName.Name = "_colProductName";
            this._colProductName.Visible = true;
            this._colProductName.VisibleIndex = 3;
            this._colProductName.Width = 150;
            // 
            // _colProcedure
            // 
            this._colProcedure.Caption = "工序";
            this._colProcedure.FieldName = "ProcedureName";
            this._colProcedure.Name = "_colProcedure";
            this._colProcedure.Visible = true;
            this._colProcedure.VisibleIndex = 2;
            this._colProcedure.Width = 103;
            // 
            // _colWorker
            // 
            this._colWorker.Caption = "工人";
            this._colWorker.FieldName = "WorkerName";
            this._colWorker.Name = "_colWorker";
            this._colWorker.Visible = true;
            this._colWorker.VisibleIndex = 1;
            this._colWorker.Width = 141;
            // 
            // _colAmount
            // 
            this._colAmount.AppearanceCell.Options.UseTextOptions = true;
            this._colAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this._colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._colAmount.Caption = "数量";
            this._colAmount.FieldName = "Amount";
            this._colAmount.Name = "_colAmount";
            this._colAmount.Visible = true;
            this._colAmount.VisibleIndex = 4;
            this._colAmount.Width = 124;
            // 
            // _colState
            // 
            this._colState.Caption = "状态";
            this._colState.Name = "_colState";
            this._colState.Visible = true;
            this._colState.VisibleIndex = 6;
            this._colState.Width = 146;
            // 
            // _colTotalPrice
            // 
            this._colTotalPrice.Caption = "总价";
            this._colTotalPrice.FieldName = "TotalPrice";
            this._colTotalPrice.Name = "_colTotalPrice";
            this._colTotalPrice.Visible = true;
            this._colTotalPrice.VisibleIndex = 5;
            this._colTotalPrice.Width = 101;
            // 
            // _colOperation
            // 
            this._colOperation.AppearanceCell.Options.UseTextOptions = true;
            this._colOperation.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._colOperation.AppearanceHeader.Options.UseTextOptions = true;
            this._colOperation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._colOperation.Caption = "操作";
            this._colOperation.ColumnEdit = this._riOperate;
            this._colOperation.MaxWidth = 120;
            this._colOperation.MinWidth = 120;
            this._colOperation.Name = "_colOperation";
            this._colOperation.Visible = true;
            this._colOperation.VisibleIndex = 7;
            this._colOperation.Width = 120;
            // 
            // _riOperate
            // 
            this._riOperate.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            editorButtonImageOptions1.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            editorButtonImageOptions2.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this._riOperate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", 40, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", 50, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this._riOperate.Name = "_riOperate";
            this._riOperate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this._riOperate.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this._riOperation_ButtonClick);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this._cbProcedures);
            this.panelControl1.Controls.Add(this.dateEdit2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.dateEdit1);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this._btnAdd);
            this.panelControl1.Controls.Add(this._btnQuery);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1032, 41);
            this.panelControl1.TabIndex = 9;
            // 
            // _cbProcedures
            // 
            this._cbProcedures.EditValue = "";
            this._cbProcedures.Location = new System.Drawing.Point(502, 11);
            this._cbProcedures.Name = "_cbProcedures";
            this._cbProcedures.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._cbProcedures.Size = new System.Drawing.Size(100, 20);
            this._cbProcedures.TabIndex = 4;
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(355, 11);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(98, 20);
            this.dateEdit2.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(337, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(12, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "到";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(235, 11);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(98, 20);
            this.dateEdit1.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(472, 14);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "工序";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(172, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "生产时间从";
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
            this._btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnAdd.Appearance.Options.UseTextOptions = true;
            this._btnAdd.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this._btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnAdd.ImageOptions.Image")));
            this._btnAdd.Location = new System.Drawing.Point(954, 7);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(64, 28);
            this._btnAdd.TabIndex = 0;
            this._btnAdd.Text = "新建";
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _btnQuery
            // 
            this._btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnQuery.Appearance.Options.UseTextOptions = true;
            this._btnQuery.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this._btnQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnQuery.ImageOptions.Image")));
            this._btnQuery.Location = new System.Drawing.Point(884, 7);
            this._btnQuery.Name = "_btnQuery";
            this._btnQuery.Size = new System.Drawing.Size(64, 28);
            this._btnQuery.TabIndex = 0;
            this._btnQuery.Text = "查询";
            this._btnQuery.Click += new System.EventHandler(this._btnQuery_Click);
            // 
            // ProduceDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "ProduceDetailView";
            this.Size = new System.Drawing.Size(1032, 656);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._riOperate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cbProcedures.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView _gridView;
        private DevExpress.XtraGrid.Columns.GridColumn _colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn _colProcedure;
        private DevExpress.XtraGrid.Columns.GridColumn _colWorker;
        private DevExpress.XtraGrid.Columns.GridColumn _colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn _colOperation;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit _riOperate;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton _btnAdd;
        private DevExpress.XtraEditors.SimpleButton _btnQuery;
        private DevExpress.XtraGrid.Columns.GridColumn _colDate;
        private DevExpress.XtraGrid.Columns.GridColumn _colState;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit _cbProcedures;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn _colTotalPrice;
    }
}
