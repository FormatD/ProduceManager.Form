using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduceManager.Form.Domains
{
    public class Entity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

    }

    public class Worker : Entity
    {

        public string Name { get; set; }

        public string Code { get; set; }


        internal string GetFriendlyName()
        {
            return string.Format("{0}({1})", Name, Code);
        }
    }

    public class Procedure : Entity
    {
        public string Name { get; set; }

        public int Order { get; set; }


        internal string GetFriendlyName()
        {
            return string.Format("{0}({1})", Name, Order);
        }
    }

    public class Product : Entity
    {

        public string Code { get; set; }

        public string Name { get; set; }

        public string GetFriendlyName()
        {
            return string.Format("{0}({1})", Name, Code);
        }

    }

    public class Price : Entity
    {
        public Procedure Procedure { get; set; }

        public Product Product { get; set; }

        public double price { get; set; }
    }

    public class Batch : Entity
    {
        public string No { get; set; }

        public int ProductId { get; set; }

        public int ExpectedAmount { get; set; }

        public DateTime StartDate { get; set; }

    }


    public class ProduceRecord : Entity
    {

        public int BatchId { get; set; }

        public int ProductId { get; set; }

        public int ProcedureId { get; set; }

        public DateTime Date { get; set; }

        public int WorkerId { get; set; }

        public int Amount { get; set; }

    }
}
