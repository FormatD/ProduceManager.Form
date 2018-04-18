using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduceManager.Forms.Domains
{

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

}
