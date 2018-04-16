namespace ProduceManager.Forms.UserControls
{
    partial class PriceConfigView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceConfigView));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraUserControl1 = new DevExpress.XtraEditors.XtraUserControl();
            this._btnSaveAll = new DevExpress.XtraEditors.SimpleButton();
            this._btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 42);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(933, 604);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // xtraUserControl1
            // 
            this.xtraUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraUserControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraUserControl1.Name = "xtraUserControl1";
            this.xtraUserControl1.Size = new System.Drawing.Size(933, 42);
            this.xtraUserControl1.TabIndex = 3;
            // 
            // _btnSaveAll
            // 
            this._btnSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSaveAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnSaveAll.ImageOptions.Image")));
            this._btnSaveAll.Location = new System.Drawing.Point(847, 8);
            this._btnSaveAll.Name = "_btnSaveAll";
            this._btnSaveAll.Size = new System.Drawing.Size(75, 23);
            this._btnSaveAll.TabIndex = 4;
            this._btnSaveAll.Text = "保存(&S)";
            this._btnSaveAll.Click += new System.EventHandler(this._btnSaveAll_Click);
            // 
            // _btnRefresh
            // 
            this._btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("_btnRefresh.ImageOptions.Image")));
            this._btnRefresh.Location = new System.Drawing.Point(766, 8);
            this._btnRefresh.Name = "_btnRefresh";
            this._btnRefresh.Size = new System.Drawing.Size(75, 23);
            this._btnRefresh.TabIndex = 4;
            this._btnRefresh.Text = "刷新(&R)";
            this._btnRefresh.Click += new System.EventHandler(this._btnRefresh_Click);
            // 
            // PriceConfigView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btnRefresh);
            this.Controls.Add(this._btnSaveAll);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.xtraUserControl1);
            this.Name = "PriceConfigView";
            this.Size = new System.Drawing.Size(933, 646);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.XtraUserControl xtraUserControl1;
        private DevExpress.XtraEditors.SimpleButton _btnSaveAll;
        private DevExpress.XtraEditors.SimpleButton _btnRefresh;
    }
}
