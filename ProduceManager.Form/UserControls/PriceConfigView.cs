using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using ProduceManager.Forms.Persistence;
using DevExpress.XtraGrid.Columns;
using ProduceManager.Forms.Domains;

namespace ProduceManager.Forms.UserControls
{
    public partial class PriceConfigView : XtraUserControl, IView
    {
        private readonly ApplicationService _service = ApplicationService.Instanse;
        private IDictionary<string, Price> _configs;
        private IList<Product> _products;
        private IList<Procedure> _procedures;

        public string Caption => "工资管理";

        public IMdiService MdiService { get; set; }

        public PriceConfigView()
        {
            InitializeComponent();
            Load += PriceConfigView_Load;
        }

        private void PriceConfigView_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            _configs = _service.GetAllPriceConfig().ToDictionary(x => $"{x.Product.Id}_{x.Procedure.Id}");
            _products = _service.GetAllProducts();
            _procedures = _service.GetAllProcedures();

            var dt = new DataTable();
            dt.Columns.Add("产品名称");

            foreach (var procedure in _procedures)
            {
                dt.Columns.Add(procedure.Name, typeof(double)).ExtendedProperties["procedure"] = procedure;
            }

            foreach (var product in _products)
            {
                var row = dt.NewRow();
                row["产品名称"] = $"{product.Name}({product.Code})";
                foreach (var procedure in _procedures)
                {
                    var key = $"{product.Id}_{procedure.Id}";
                    row[procedure.Name] = _configs.ContainsKey(key) ? (object)_configs[key].price : DBNull.Value;
                }
                dt.Rows.Add(row);
            }

            gridView.Columns.Clear();
            gridView.Columns.Add(new GridColumn
            {
                Caption = "产品名称",
                FieldName = "产品名称",
                Visible = true,
            });
            //gridView.Columns[0].EditKC = true;

            foreach (var procedure in _procedures)
            {
                gridView.Columns.Add(new GridColumn
                {
                    Caption = procedure.Name,
                    FieldName = procedure.Name,
                    Visible = true,
                });

            }

            gridControl.DataSource = dt;
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        public void Jump(object parameter)
        {
        }

        private void _btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void _btnSaveAll_Click(object sender, EventArgs e)
        {
            var dt = gridControl.DataSource as DataTable;

            var configs = new List<Price>();
            for (int rowIndex = 0; rowIndex < _products.Count; rowIndex++)
            {
                var productd = _products[rowIndex];
                var row = dt.Rows[rowIndex];
                foreach (var column in dt.Columns.OfType<DataColumn>().Skip(1))
                {
                    var procedure = column.ExtendedProperties["procedure"] as Procedure;
                    var price = row[column];

                    if (price != DBNull.Value)
                        configs.Add(new Price
                        {
                            Product = productd,
                            Procedure = procedure,
                            price = (double)price,
                        });
                }
            }

            _service.DeleteAllPrice();
            _service.AddPriceList(configs);
        }
    }
}
