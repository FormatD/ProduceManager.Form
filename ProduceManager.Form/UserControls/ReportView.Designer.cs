namespace ProduceManager.Forms.UserControls
{
    partial class ReportView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportView));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this._tlReports = new DevExpress.XtraTreeList.TreeList();
            this._colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this._colOperation = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this._riOperate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this._tlReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._riOperate)).BeginInit();
            this.SuspendLayout();
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(221, 0);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(840, 759);
            this.documentViewer1.TabIndex = 0;
            // 
            // _tlReports
            // 
            this._tlReports.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this._colName,
            this._colOperation});
            this._tlReports.Dock = System.Windows.Forms.DockStyle.Left;
            this._tlReports.Location = new System.Drawing.Point(0, 0);
            this._tlReports.Name = "_tlReports";
            this._tlReports.BeginUnboundLoad();
            this._tlReports.AppendNode(new object[] {
            "报表1",
            null}, -1);
            this._tlReports.EndUnboundLoad();
            this._tlReports.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this._riOperate});
            this._tlReports.Size = new System.Drawing.Size(216, 759);
            this._tlReports.TabIndex = 3;
            // 
            // _colName
            // 
            this._colName.Caption = "报表名称";
            this._colName.FieldName = "Name";
            this._colName.MinWidth = 34;
            this._colName.Name = "_colName";
            this._colName.OptionsColumn.AllowEdit = false;
            this._colName.OptionsColumn.AllowSort = false;
            this._colName.OptionsColumn.ShowInExpressionEditor = false;
            this._colName.OptionsFilter.AllowAutoFilter = false;
            this._colName.OptionsFilter.AllowFilter = false;
            this._colName.Visible = true;
            this._colName.VisibleIndex = 0;
            this._colName.Width = 174;
            // 
            // _colOperation
            // 
            this._colOperation.ColumnEdit = this._riOperate;
            this._colOperation.MinWidth = 40;
            this._colOperation.Name = "_colOperation";
            this._colOperation.OptionsColumn.AllowSize = false;
            this._colOperation.OptionsColumn.AllowSort = false;
            this._colOperation.OptionsColumn.ShowInCustomizationForm = false;
            this._colOperation.OptionsColumn.ShowInExpressionEditor = false;
            this._colOperation.Visible = true;
            this._colOperation.VisibleIndex = 1;
            this._colOperation.Width = 60;
            // 
            // _riOperate
            // 
            this._riOperate.AutoHeight = false;
            this._riOperate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("_riOperate.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "设计报表", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("_riOperate.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "删除报表", null, null, true)});
            this._riOperate.Name = "_riOperate";
            this._riOperate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this._riOperate.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this._riOperate_ButtonClick);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(216, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 759);
            this.splitterControl1.TabIndex = 4;
            this.splitterControl1.TabStop = false;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.documentViewer1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this._tlReports);
            this.Name = "ReportView";
            this.Size = new System.Drawing.Size(1061, 759);
            ((System.ComponentModel.ISupportInitialize)(this._tlReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._riOperate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraTreeList.TreeList _tlReports;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn _colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn _colOperation;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit _riOperate;
    }
}
