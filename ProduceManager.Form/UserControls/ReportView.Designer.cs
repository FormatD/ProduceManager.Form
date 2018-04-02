namespace ProduceManager.Form.UserControls
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
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this._colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.DocumentSource = typeof(ProduceManager.Form.UserControls.XtraReport1);
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(221, 0);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(840, 759);
            this.documentViewer1.TabIndex = 0;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this._colName});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "报表1"}, -1);
            this.treeList1.EndUnboundLoad();
            this.treeList1.Size = new System.Drawing.Size(216, 759);
            this.treeList1.TabIndex = 3;
            // 
            // _colName
            // 
            this._colName.Caption = "报表名称";
            this._colName.FieldName = "报表名称";
            this._colName.MinWidth = 34;
            this._colName.Name = "_colName";
            this._colName.Visible = true;
            this._colName.VisibleIndex = 0;
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
            this.Controls.Add(this.treeList1);
            this.Name = "ReportView";
            this.Size = new System.Drawing.Size(1061, 759);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn _colName;
    }
}
