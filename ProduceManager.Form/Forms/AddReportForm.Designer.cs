﻿namespace ProduceManager.Forms
{
    partial class AddReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReportForm));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this._txtDataSource = new FastColoredTextBoxNS.FastColoredTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this._txtReportName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this._chkIsSystem = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this._btnDesign = new DevExpress.XtraEditors.SimpleButton();
            this._btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this._btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtReportName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsSystem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this._txtDataSource);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this._txtReportName);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this._chkIsSystem);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(689, 364);
            this.panelControl2.TabIndex = 1;
            // 
            // _txtDataSource
            // 
            this._txtDataSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtDataSource.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this._txtDataSource.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this._txtDataSource.BackBrush = null;
            this._txtDataSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtDataSource.CharHeight = 14;
            this._txtDataSource.CharWidth = 8;
            this._txtDataSource.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtDataSource.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._txtDataSource.IsReplaceMode = false;
            this._txtDataSource.Location = new System.Drawing.Point(133, 111);
            this._txtDataSource.Name = "_txtDataSource";
            this._txtDataSource.Paddings = new System.Windows.Forms.Padding(0);
            this._txtDataSource.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this._txtDataSource.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("_txtDataSource.ServiceColors")));
            this._txtDataSource.Size = new System.Drawing.Size(544, 247);
            this._txtDataSource.TabIndex = 3;
            this._txtDataSource.Zoom = 100;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(78, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "数据源";
            // 
            // _txtReportName
            // 
            this._txtReportName.Location = new System.Drawing.Point(135, 21);
            this._txtReportName.Name = "_txtReportName";
            this._txtReportName.Size = new System.Drawing.Size(251, 20);
            this._txtReportName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(66, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "报表名称";
            // 
            // _chkIsSystem
            // 
            this._chkIsSystem.EditValue = null;
            this._chkIsSystem.Location = new System.Drawing.Point(133, 66);
            this._chkIsSystem.Name = "_chkIsSystem";
            this._chkIsSystem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this._chkIsSystem.Properties.Caption = "是系统报表";
            this._chkIsSystem.Properties.ReadOnly = true;
            this._chkIsSystem.Size = new System.Drawing.Size(251, 19);
            this._chkIsSystem.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this._btnDesign);
            this.panelControl1.Controls.Add(this._btnCancel);
            this.panelControl1.Controls.Add(this._btnAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 364);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(689, 46);
            this.panelControl1.TabIndex = 0;
            // 
            // _btnDesign
            // 
            this._btnDesign.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnDesign.Location = new System.Drawing.Point(26, 11);
            this._btnDesign.Name = "_btnDesign";
            this._btnDesign.Size = new System.Drawing.Size(64, 23);
            this._btnDesign.TabIndex = 1;
            this._btnDesign.Text = "设计(&D)";
            this._btnDesign.Click += new System.EventHandler(this._btnDesign_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(529, 11);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(64, 23);
            this._btnCancel.TabIndex = 1;
            this._btnCancel.Text = "取消(&C)";
            // 
            // _btnAdd
            // 
            this._btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnAdd.Location = new System.Drawing.Point(605, 11);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(64, 23);
            this._btnAdd.TabIndex = 0;
            this._btnAdd.Text = "添加(&A)";
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // AddReportForm
            // 
            this.AcceptButton = this._btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(689, 410);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加报表";
            this.Load += new System.EventHandler(this.AddReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtReportName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chkIsSystem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit _txtReportName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton _btnCancel;
        private DevExpress.XtraEditors.SimpleButton _btnAdd;
        private DevExpress.XtraEditors.SimpleButton _btnDesign;
        private DevExpress.XtraEditors.CheckEdit _chkIsSystem;
        private FastColoredTextBoxNS.FastColoredTextBox _txtDataSource;
    }
}