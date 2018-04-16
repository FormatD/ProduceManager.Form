using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduceManager.Forms.Domains
{
    public class Entity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

    }

    public interface IDisplayable
    {
        string GetDisplayText();
    }

    public class Worker : Entity, IDisplayable
    {

        public string Name { get; set; }

        public string Code { get; set; }

        public string DisplayText => GetDisplayText();

        public string GetDisplayText()
        {
            return string.Format("{0}({1})", Name, Code);
        }

        public override string ToString()
        {
            return GetDisplayText();
        }
    }

    public class Procedure : Entity, IDisplayable
    {
        public string Name { get; set; }

        public int Order { get; set; }
        public string DisplayText => GetDisplayText();

        public string GetDisplayText()
        {
            return string.Format("{0}({1})", Name, Order);
        }

        public override string ToString()
        {
            return GetDisplayText();
        }
    }

    public class Product : Entity, IDisplayable
    {

        public string Code { get; set; }

        public string Name { get; set; }

        public string GetDisplayText()
        {
            return string.Format("{0}({1})", Name, Code);
        }

        public override string ToString()
        {
            return GetDisplayText();
        }

    }

    public class Price : Entity
    {
        public Procedure Procedure { get; set; }

        public Product Product { get; set; }

        public double price { get; set; }
    }

    public class Batch : Entity, IDisplayable
    {
        public string No { get; set; }

        public int ProductId { get; set; }

        public int ExpectedAmount { get; set; }

        public DateTime StartDate { get; set; }

        public string GetDisplayText()
        {
            return No;
        }

        public override string ToString()
        {
            return GetDisplayText();
        }
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

    public class ReportItem : Entity
    {
        public string Name { get; set; }

        public string DataSource { get; set; }

        public byte[] Content { get; set; }

        public bool IsSystem { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

}
