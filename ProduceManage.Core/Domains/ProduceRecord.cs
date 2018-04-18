using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduceManager.Forms.Domains
{

    public class ProduceRecord : Entity
    {

        public DateTime Date { get; set; }

        public Batch Batch { get; set; }

        public Product Product { get; set; }

        public Procedure Procedure { get; set; }

        public Worker Worker { get; set; }

        public int Amount { get; set; }

    }

}
