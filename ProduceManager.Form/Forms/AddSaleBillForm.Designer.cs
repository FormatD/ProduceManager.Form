namespace ProduceManager.Forms
{
    partial class AddSaleBillForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSaleBillForm));
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this._btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this._btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.saleBillItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this._leProducts = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this._cbProducts = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._txtCustomName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this._txtBillNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBillItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._leProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtCustomName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtBillNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colAmount
            // 
            this.colAmount.Caption = "数量";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "SUM={0:0.##}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "合价";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "SUM={0:0.##}")});
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this._btnCancel);
            this.panelControl1.Controls.Add(this._btnAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 271);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(563, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(403, 11);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(64, 23);
            this._btnCancel.TabIndex = 1;
            this._btnCancel.Text = "取消(&C)";
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnAdd
            // 
            this._btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnAdd.Location = new System.Drawing.Point(479, 11);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(64, 23);
            this._btnAdd.TabIndex = 0;
            this._btnAdd.Text = "添加(&A)";
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Controls.Add(this._txtCustomName);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this._txtBillNo);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(563, 271);
            this.panelControl2.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.saleBillItemBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 76);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this._cbProducts,
            this._leProducts});
            this.gridControl1.Size = new System.Drawing.Size(548, 180);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // saleBillItemBindingSource
            // 
            this.saleBillItemBindingSource.DataSource = typeof(ProduceManager.Forms.Domains.SaleBillItem);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct,
            this.colPrice,
            this.colAmount,
            this.colTotalPrice});
            gridFormatRule1.Column = this.colAmount;
            gridFormatRule1.ColumnApplyTo = this.colTotalPrice;
            gridFormatRule1.Name = "Format0";
            gridFormatRule1.Rule = null;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TotalPrice", this.colTotalPrice, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 1;
            this.gridView1.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.GridView1_ValidateRow);
            // 
            // colProduct
            // 
            this.colProduct.Caption = "产品";
            this.colProduct.ColumnEdit = this._leProducts;
            this.colProduct.FieldName = "ProductName";
            this.colProduct.Name = "colProduct";
            this.colProduct.Visible = true;
            this.colProduct.VisibleIndex = 0;
            // 
            // _leProducts
            // 
            this._leProducts.AutoHeight = false;
            this._leProducts.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._leProducts.Name = "_leProducts";
            this._leProducts.PopupFilter += new DevExpress.XtraEditors.Controls.PopupFilterEventHandler(this._leProducts_PopupFilter);
            this._leProducts.EditValueChanged += new System.EventHandler(this._leProducts_EditValueChanged);
            // 
            // colPrice
            // 
            this.colPrice.Caption = "单价";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 1;
            // 
            // _cbProducts
            // 
            this._cbProducts.AutoHeight = false;
            this._cbProducts.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._cbProducts.Name = "_cbProducts";
            this._cbProducts.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // _txtCustomName
            // 
            this._txtCustomName.Location = new System.Drawing.Point(80, 38);
            this._txtCustomName.Name = "_txtCustomName";
            this._txtCustomName.Size = new System.Drawing.Size(150, 20);
            this._txtCustomName.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "客户名称";
            // 
            // _txtBillNo
            // 
            this._txtBillNo.Location = new System.Drawing.Point(80, 12);
            this._txtBillNo.Name = "_txtBillNo";
            this._txtBillNo.Properties.ReadOnly = true;
            this._txtBillNo.Size = new System.Drawing.Size(150, 20);
            this._txtBillNo.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "销售单号";
            // 
            // AddSaleBillForm
            // 
            this.AcceptButton = this._btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(563, 317);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSaleBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加销售单";
            this.Load += new System.EventHandler(this.AddBatchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBillItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._leProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cbProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtCustomName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtBillNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton _btnCancel;
        private DevExpress.XtraEditors.SimpleButton _btnAdd;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit _txtBillNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource saleBillItemBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraEditors.TextEdit _txtCustomName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit _cbProducts;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit _leProducts;
    }
}