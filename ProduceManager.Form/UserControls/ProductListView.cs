using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProduceManager.Forms.Persistence;
using ProduceManager.Forms.Domains;
using ProduceManager.Forms.Utils;

namespace ProduceManager.Forms
{
    public partial class ProductListView : UserControl, IView
    {
        readonly ApplicationService _service;
        private IList<Product> _productList;

        public IMdiService MdiService { get; set; }

        public string Caption { get { return "产品管理"; } }

        public ProductListView()
        {
            InitializeComponent();

            _service = ApplicationService.Instanse;
            this.Load += BatchListView_Load;
        }

        void BatchListView_Load(object sender, EventArgs e)
        {
            XtraGridHelper.SetSortable(_gridView);//禁用排序
            XtraGridHelper.SetGridViewStyle(_gridView, new[] { _colOperation });
            XtraGridHelper.DrawRowIndicator(_gridView);   //初始化序号 
            XtraGridHelper.BindCopyToCtrlC(gridControl);
            Query();
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new AddProductForm())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    Query();
            }
        }

        private void _btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void Query()
        {
            var currentBatchId = GetFocusedProductId();
            gridControl.DataSource = _productList = _service.GetAllProducts();

            JumpTo(currentBatchId);
        }

        private void _gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            var product = _productList[e.ListSourceRowIndex];

            if (e.Column == _colState)
            {
                if (product.IsDeleted)
                    e.DisplayText = "已删除";
                else
                    e.DisplayText = "正常";
            }
        }

        private void _riOperation_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                MdiService.JumpTo<ProduceDetailView>();
            }
            else if (e.Button.Index == 1)
            {
                var product = GetFocusedProduct();
                if (product == null)
                {
                    MessageBoxHelper.Warn("没有找到产品。");
                    return;
                }

                using (var dlg = new AddProductForm(product.Id))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                        Query();
                }
            }
            else if (e.Button.Index == 2)
            {
                var product = GetFocusedProduct();
                if (product == null)
                {
                    MessageBoxHelper.Warn("没有找到产品。");
                    return;
                }

                if (MessageBoxHelper.Question(string.Format("您确定要删除产品“{0}”吗?", product.GetDisplayText())))
                {
                    _service.DeleteProduct(product.Id);
                }
            }
        }

        private int GetFocusedProductId()
        {
            var focusedBatch = GetFocusedProduct();
            var currentBatchId = focusedBatch != null ? focusedBatch.Id : -1;
            return currentBatchId;
        }

        private Product GetFocusedProduct()
        {
            var rows = _gridView.GetSelectedRows();
            return rows.Any() ? (Product)_gridView.GetRow(rows.First()) : null;
        }

        public void Jump(object parameter)
        {
            if (parameter is int batchId)
            {
                JumpTo(batchId);
            }
        }

        private void JumpTo(int batchId)
        {
            var batch = _productList.FirstOrDefault(x => x.Id == batchId);
            var index = _productList.IndexOf(batch);
            _gridView.FocusedRowHandle = _gridView.GetRowHandle(index);
        }

    }
}
