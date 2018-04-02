using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProduceManager.Form.UserControls
{
    public partial class ReportView : XtraUserControl, IView
    {
        public ReportView()
        {
            InitializeComponent();
        }

        public string Caption
        {
            get { return "报表"; }
        }

        public IMdiService MdiService { get; set; }

        public void Jump(object parameter)
        {
        }
    }
}
