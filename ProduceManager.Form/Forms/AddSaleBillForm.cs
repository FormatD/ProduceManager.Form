using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ProduceManager.Forms.Persistence;
using ProduceManager.Forms.Domains;
using ProduceManager.Forms.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.Filtering;

namespace ProduceManager.Forms
{
    public partial class AddSaleBillForm : XtraForm
    {
        private bool _isAddingNew;
        private SaleBill saleBill;
        private int _saleBillId;
        ApplicationService _service;
        private IList<Product> _productList;

        public AddSaleBillForm()
        {
            _service = ApplicationService.Instanse;
            InitializeComponent();
            _isAddingNew = true;
            saleBill = new SaleBill { BillNo = "新销售单", Items = new List<SaleBillItem>() };
        }

        public AddSaleBillForm(int saleBillId)
        {
            _service = ApplicationService.Instanse;
            InitializeComponent();
            _saleBillId = saleBillId;
            saleBill = _service.GetSaleBill(_saleBillId);
        }

        private void AddBatchForm_Load(object sender, EventArgs e)
        {
            gridView1.CustomDrawFooterCell += GridView1_CustomDrawFooterCell;

            gridControl1.DataSource = saleBill.Items;

            _leProducts.DataSource = _productList = _service.GetAllProducts();
            _leProducts.TextEditStyle = TextEditStyles.Standard;
            _leProducts.ImmediatePopup = true;
            _leProducts.DisplayMember = "Name";
            _leProducts.ValueMember = "Name";

            _leProducts.EditValueChanging += _leProducts_EditValueChanging;

            _txtBillNo.Text = saleBill.BillNo;
            _txtCustomName.Text = saleBill.CustomeName;
        }

        private void GridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            var name = _txtCustomName.Text;
            var items = gridControl1.DataSource as IList<SaleBillItem>;

            if (!_txtCustomName.Validate(string.IsNullOrWhiteSpace(name))
                || !gridControl1.Validate(items == null || !items.Any()))
            {
                return;
            }

            if (_isAddingNew)
            {
                saleBill.CustomeName = name;
                saleBill.BillNo = SequenseNoGenerator.GetNextCode("XS");
                _service.AddSaleBill(saleBill);
            }
            else
            {
                saleBill.CustomeName = name;
                saleBill.Items = gridControl1.DataSource as IList<SaleBillItem>;

                _service.SaveSaleBill(saleBill);
            }

            DialogResult = DialogResult.OK;
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var row = gridView1.GetRow(gridView1.FocusedRowHandle);

        }

        Product product;
        private void _leProducts_EditValueChanging(object sender, ChangingEventArgs e)
        {
            product = _productList.FirstOrDefault(x => x.Name == e.NewValue.ToString());
        }

        private void _leProducts_PopupFilter(object sender, PopupFilterEventArgs e)
        {
            if (string.IsNullOrEmpty(e.SearchText)) return;
            var edit = _leProducts;// sender as LookUpEdit;
            PropertyDescriptorCollection propertyDescriptors = ListBindingHelper.GetListItemProperties(edit.DataSource);
            IEnumerable<FunctionOperator> operators = propertyDescriptors.OfType<PropertyDescriptor>()
                .Select(t => new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(t.Name), new OperandValue(e.SearchText)));
            e.Criteria = new GroupOperator(GroupOperatorType.Or, operators);
            e.SuppressSearchCriteria = true;
        }

        private void _leProducts_EditValueChanged(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle && product != null)
            {
                var row = gridView1.GetRow(gridView1.FocusedRowHandle);

                var dataSource = gridControl1.DataSource as List<SaleBillItem>;
                dataSource.Add(new SaleBillItem
                {
                    Product = product,
                    Price = 0,
                    Amount = 0,
                    ProductName = product.Name,
                });

                gridControl1.RefreshDataSource();
                gridView1.FocusedRowHandle = dataSource.Count;
            }
            else if (product != null)
            {
                var focusedSaleBillItem = gridView1.GetFocusedRow() as SaleBillItem;
                focusedSaleBillItem.Product = product;
            }
        }
    }
}