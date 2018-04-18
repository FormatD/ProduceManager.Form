using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduceManager.Forms.Domains
{
    public class SaleBill : Entity
    {
        public string BillNo { get; set; }

        public string CustomeName { get; set; }

        public DateTime Date { get; set; }

        public IList<SaleBillItem> Items { get; set; }

        public double TotalPrice => Items?.Sum(x => x.TotalPrice) ?? 0;

        public object GetDisplayText()
        {
            return BillNo;
        }
    }

    public class SaleBillItem : Entity
    {

        public Product Product { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }

        public double Discount { get; set; }

        public double TotalPrice => Amount * Price - Discount;

        public string ProductName
        {
            get { return Product?.Name; }
            set { }
        }
    }
}
